using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public interface IHttpClient
    {
        Task<string> GetStringAsync(string uri, string authToken = null,
            string authMethod = "Bearer");

        Task<HttpResponseMessage> PostAsync<T>(string uri,T item, string authToken = null,
            string authMethod = "Bearer");

        Task<HttpResponseMessage> PutAsync<T>(string uri, T item, string authToken = null,
            string authMethod = "Bearer");

        Task<HttpResponseMessage> DeleteAsync<T>(string uri, string authToken = null,
            string authMethod = "Bearer");

    }
}
