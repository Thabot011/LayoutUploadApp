using AkaratiCheckScanner.Services;
using ClosedXML.Excel;
using LayoutUploadApp.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows.Forms.Design;


namespace LayoutUploadApp
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            ApplicationConfiguration.Initialize();

            GlobalSetting.BaseUrl = Program.Configuration["BaseUrl"];

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // Get the startup form from the container
                var loginForm = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(loginForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Register services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ILookupService, LookupService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IXLWorkbook, XLWorkbook>();

            // Register forms
            services.AddTransient<LoginForm>();
            services.AddTransient<UploadLayoutFrom>();
        }
    }
}