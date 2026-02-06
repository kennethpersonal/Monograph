namespace WEB.Services
{
    public class MonographService : IMonograph
    {
        private readonly HttpClient _httpClient;
        public MonographService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> InvokeGetAsync<T>(string uri)
        {
            return await _httpClient.GetFromJsonAsync<T>(uri);
        }
    }
}
