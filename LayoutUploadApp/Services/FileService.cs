using Azure.Storage.Blobs;
using ClosedXML.Excel;
using Eveorex.CRM.DataModel;
using LayoutUploadApp.Model;

namespace LayoutUploadApp.Services
{
    public class FileService : IFileService
    {
        private IXLWorkbook _xLWorkbook;
        private readonly ILookupService _lookupService;
        private readonly string _connectionStrings;
        private readonly string _containerName;
        private readonly int _fileSizeLimit;
        public FileService(IXLWorkbook xLWorkbook, ILookupService lookupService)
        {
            _xLWorkbook = xLWorkbook;
            _lookupService = lookupService;
            var section = Program.Configuration.GetSection("AzureBlobStorage");
            _connectionStrings = section["ConnectionStrings"];
            _containerName = section["ContainerName"];
            _fileSizeLimit = int.Parse(Program.Configuration["FileSizeLimit"].ToString());
        }

        public async Task DownloadTemplate()
        {
            IXLWorksheet? workSheet = null;
            if (_xLWorkbook.Worksheets.Any(ws => ws.Name == "Layout template"))
            {
                workSheet = _xLWorkbook.Worksheet("Layout template"); // Get existing sheet
            }
            else
            {
                workSheet = _xLWorkbook.AddWorksheet("Layout template"); // Add new sheet
            }

            workSheet.Cell(1, 1).Value = "Property Id";
            workSheet.Cell(1, 2).Value = "Unit Number";
            workSheet.Cell(1, 3).Value = "Layout file name";

            var units = _lookupService.GetLookups();

            List<Task> LayoutSheetTasks = new List<Task>();

            for (int i = 0; i < units.Count; i++)
            {
                int index = i;
                LayoutSheetTasks.Add(Task.Run(() =>
                {
                    workSheet.Cell(index + 2, 1).Value = units[index].Id;
                    workSheet.Cell(index + 2, 2).Value = units[index].Name;
                }));

            }

            await Task.WhenAll(LayoutSheetTasks);
            _xLWorkbook.SaveAs("LayoutSheet.xlsx");
        }

        public async Task<List<SaveUnitLayoutRequest>> UploadTemplate(string folderPath, List<string> propertiesIds, List<string> unitsIds, ProgressBar progressBar)
        {
            _xLWorkbook = new XLWorkbook("LayoutSheet.xlsx");
            var worksheet = _xLWorkbook.Worksheet("Layout template");
            var rows = worksheet.RangeUsed()?.RowsUsed().Skip(1).ToList();
            if (rows == null)
            {
                return null;
            }
            var filePathes = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly).Where(file => new FileInfo(file).Length <= _fileSizeLimit).ToList();

            if (IsFileCorrect(rows, filePathes, propertiesIds, unitsIds))
            {
                var blobServiceClient = new BlobServiceClient(_connectionStrings);
                var containerClient = blobServiceClient.GetBlobContainerClient(_containerName);
                await containerClient.CreateIfNotExistsAsync();
                List<SaveUnitLayoutRequest> UploadedUnits = new List<SaveUnitLayoutRequest>();
                progressBar.Minimum = 0;
                progressBar.Maximum = filePathes.Count;
                progressBar.Value = 0;
                await Parallel.ForEachAsync(filePathes, async (filePath, c) =>
                {
                    string fileName = Path.GetFileName(filePath);
                    var row = rows.FirstOrDefault(r => r.Cell(3).GetString() == fileName);
                    string blobName = $"DeveloperName/{DateTime.Now.Year}/Units/{row.Cell(1).GetString()}/UnitLayout/{fileName}";
                    BlobClient blobClient = containerClient.GetBlobClient(blobName);
                    using FileStream fileStream = File.OpenRead(filePath);
                    var result = await blobClient.UploadAsync(fileStream, overwrite: true);
                    await progressBar.InvokeAsync(() =>
                     {
                         progressBar.Value++;
                     });
                    UploadedUnits.Add(new SaveUnitLayoutRequest
                    {
                        FileName = fileName,
                        Url = blobClient.Uri.ToString(),
                        UnitId = row.Cell(1).GetString()
                    });
                });
                return UploadedUnits;
            }
            return null;
        }


        private bool IsFileCorrect(List<IXLRangeRow> rows, List<string> filePathes, List<string> PropertyIds, List<string> UnitNumbers)
        {
            List<string> properties = rows.Select(r => r.Cell(1).Value.ToString()).ToList();
            List<string> units = rows.Select(r => r.Cell(2).Value.ToString()).ToList();
            List<string> fileUrls = rows.Select(r => r.Cell(3).Value.ToString()).ToList();

            bool sameProperties = PropertyIds.OrderBy(x => x).SequenceEqual(properties.OrderBy(x => x));
            bool sameUnits = UnitNumbers.OrderBy(x => x).SequenceEqual(units.OrderBy(x => x));
            bool sameFiles = filePathes.Select(x => Path.GetFileName(x)).OrderBy(x => x).SequenceEqual(fileUrls.OrderBy(x => x));
            if (sameProperties && sameUnits && sameFiles)
            {
                return true;
            }
            return false;
        }
    }
}
