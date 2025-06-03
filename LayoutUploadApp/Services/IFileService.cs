using Eveorex.CRM.DataModel;
using LayoutUploadApp.Model;

namespace LayoutUploadApp.Services
{
    public interface IFileService
    {
        Task DownloadTemplate();
        Task<List<SaveUnitLayoutRequest>> UploadTemplate(string folderPath, List<string> propertiesIds, List<string> unitsIds);
    }
}
