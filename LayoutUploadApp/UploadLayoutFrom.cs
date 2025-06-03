using LayoutUploadApp.Model;
using LayoutUploadApp.Services;

namespace LayoutUploadApp
{
    public partial class UploadLayoutFrom : Form
    {
        private readonly ILookupService _lookupService;
        private readonly IFileService _fileService;
        public UploadLayoutFrom(ILookupService lookupService, IFileService fileService)
        {
            _lookupService = lookupService;
            _fileService = fileService;
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e)
        {
            await GlobalSetting.ProgressLoading(UploadLayoutProgress);
            ProjectNameDDL.DataSource = _lookupService.GetLookups();
            await GlobalSetting.ProgressStop(UploadLayoutProgress);
        }

        private async void BuildingnameDDl_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GlobalSetting.ChangeControlsEnabledProperty(true, DownloadTemplateBtn);
        }

        private async void DownloadTemplateBtn_Click(object sender, EventArgs e)
        {
            await GlobalSetting.ProgressLoading(UploadLayoutProgress);
            await _fileService.DownloadTemplate();
            await GlobalSetting.ProgressStop(UploadLayoutProgress, LayoutFolderTxt, UploadTemplateBtn);
        }

        private async void UploadTemplateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LayoutFolderTxt.Text))
            {
                LayoutUploadErrorProvider.SetError(LayoutFolderTxt, "Folder path is required");
            }
            else
            {
                await GlobalSetting.ProgressLoading(UploadLayoutProgress);
                var unitsUploaded = await _fileService.UploadTemplate(LayoutFolderTxt.Text, _lookupService.GetLookups().Select(x => x.Id.ToString()).ToList(), _lookupService.GetLookups().Select(x => x.Name).ToList(),UploadLayoutProgress);
                await GlobalSetting.ProgressStop(UploadLayoutProgress, UploadBtn);
                if (unitsUploaded == null || !unitsUploaded.Any())
                {
                    LayoutUploadErrorProvider.SetError(UploadTemplateBtn, "Upload Failed, Please make sure that excel file matches the files uploaded in the folder");
                    await GlobalSetting.ChangeControlsEnabledProperty(false, UploadBtn);
                    return;
                }
                LayoutUploadErrorProvider.Clear();
                await GlobalSetting.ChangeControlsEnabledProperty(true, UploadBtn);
                MessageBox.Show("File validation successed you can upload now.", "File validation successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void UploadBtn_Click(object sender, EventArgs e)
        {
            await GlobalSetting.ChangeControlsEnabledProperty(false, BuildingnameDDl, DownloadTemplateBtn, LayoutFolderTxt, UploadTemplateBtn, UploadBtn);
        }

        private async void ProjectNameDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GlobalSetting.ProgressLoading(UploadLayoutProgress);
            BuildingnameDDl.DataSource = _lookupService.GetLookups();
            await GlobalSetting.ProgressStop(UploadLayoutProgress, BuildingnameDDl);
        }
    }
}
