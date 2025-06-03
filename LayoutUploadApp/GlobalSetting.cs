using System.Threading.Tasks;

namespace LayoutUploadApp
{
    public static class GlobalSetting
    {
        public static string AuthToken { get; set; }
        public static string BaseUrl { get; set; }

        public static async Task ProgressLoading(ProgressBar progressBar, params Control[] controls)
        {
            progressBar.Visible = true;
            await ChangeControlsEnabledProperty(false, controls);
        }

        public static async Task ProgressStop(ProgressBar progressBar, params Control[] controls)
        {
            progressBar.Visible = false;
            await ChangeControlsEnabledProperty(true, controls);
        }

        public static async Task ChangeControlsEnabledProperty(bool enabled, params Control[] controls)
        {
            Parallel.ForEach(controls, async (control) =>
           {
               await control.InvokeAsync(() =>
                 {
                     control.Enabled = enabled;
                 });
           });
        }
    }
}
