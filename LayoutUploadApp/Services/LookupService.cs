using LayoutUploadApp.Model;

namespace LayoutUploadApp.Services
{
    public class LookupService : ILookupService
    {
        private readonly HttpClient _httpClient;

        public LookupService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(GlobalSetting.BaseUrl);
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", GlobalSetting.AuthToken);
        }
        public List<Lookup> GetLookups()
        {
            return new List<Lookup>
            {
                new Lookup()
                {
                    Id=1,
                    Name="test2"
                },
                new Lookup()
                {
                    Id=2,
                    Name="test2"
                },
                new Lookup()
                {
                    Id=3,
                    Name="test3"
                }
            };
        }
    }
}
