using LayoutUploadApp;
using LayoutUploadApp.Services;
using Newtonsoft.Json;
using System.Net;
using System.Text;



namespace AkaratiCheckScanner.Services
{
    public class AuthService:IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(GlobalSetting.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalSetting.AuthToken);
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            var request = new
            {
                username,
                password,
                identifier = "mL5WislMnggrmNaw4/h3pg=="
            };

            string jsonData = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"/v1/token", content);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}

