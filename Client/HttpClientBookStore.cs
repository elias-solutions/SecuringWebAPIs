namespace Client
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    class HttpClientBookStore
    {
        private readonly HttpClient _httpClient;
        private const string URL = "https://localhost:5001/api/v1/";


        public HttpClientBookStore()
        {
            _httpClient = new HttpClient {BaseAddress = new Uri(URL)};
        }

        public Task DeleteAsync(string identifier, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization", "Bearer " + token);
            return _httpClient.DeleteAsync($"books/{identifier}");
        }
    }
}