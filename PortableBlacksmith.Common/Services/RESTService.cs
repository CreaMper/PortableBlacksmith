using PortableBlacksmith.Common.Utils;
using System.Net.Http.Json;

namespace PortableBlacksmith.Blazor.Services
{
    public class RESTService : IRESTService 
    {
        public readonly HttpClient _httpClient;
        public RESTService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IRESTResult<T>> GetAsync<T>(string endpointRoute)
        {
            var response = await _httpClient.GetAsync(endpointRoute);
            var restResult = new RESTResult<T>()
            {
                StatusCode = response.StatusCode,
                RequestUri = response.RequestMessage.RequestUri,
                Method = "GET"
            };

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadFromJsonAsync<T>();
                restResult.Result = responseData;
                restResult.IsSuccess = true;
                return restResult;

            }
            else
            {
                restResult.IsSuccess = false;
                return restResult;
            }
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
