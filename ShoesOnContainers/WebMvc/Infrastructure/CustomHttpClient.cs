using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public class CustomHttpClient : IHttpClient
    {
        private HttpClient _client;

        public CustomHttpClient()
        {
            _client = new HttpClient();
        }



        public Task<HttpResponseMessage> DeleteAsync<T>(string uri, string authToken = null, string authMethod = "Bearer")
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetStringAsync(string uri, string authToken = null, string authMethod = "Bearer")
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);

            var response  = await _client.SendAsync(request);

            return await response.Content.ReadAsStringAsync();

        }

        public Task<HttpResponseMessage> PostAsync<T>(string uri, T item, string authToken = null, string authMethod = "Bearer")
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync<T>(string uri, T item, string authToken = null, string authMethod = "Bearer")
        {
            throw new NotImplementedException();
        }
    }
}
