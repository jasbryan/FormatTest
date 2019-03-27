using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Infrastructure;
using WebMvc.Models;

namespace WebMvc.Services
{
    public class CatalogService
    {
        private IHttpClient _client;
        private IConfiguration _config;
        private readonly string _remoteServiceBaseUrl;

        public CatalogService(IHttpClient client, IConfiguration config)
        {
            _client = client;
            _remoteServiceBaseUrl = $"{config["CatalogUrl"]}/api/catalog/";
        }

        public async Task<Catalog> GetCatalogItemsAsync(int page, int size, int? brand, int? type)
        {
            var allCatalogItemsUri = ApiPaths.Catalog.GetAllCatalogItems(_remoteServiceBaseUrl, size, page, brand, type);
            var dataString = await _client.GetStringAsync(allCatalogItemsUri);
            var response = JsonConvert.DeserializeObject<Catalog>(dataString);
            return response;
        }

        public async Task<IEnumerable<SelectListItem>> GetBrandsAsync()
        {
            var brandsUri = ApiPaths.Catalog.GetAllBrands(_remoteServiceBaseUrl);
            var dataString = await _client.GetStringAsync(brandsUri);
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value=null,
                    Text="All",
                    Selected = true
                }
            };

            var data = JArray.Parse(dataString);
            foreach (var brand in data)
            {
                items.Add(new SelectListItem
                {
                    Value = brand.Value<string>("Id"),
                    Text = brand.Value<string>("brand")
                });
            }
            return items;
        }

        public async Task<IEnumerable<SelectListItem>> GetTypesAsync()
        {
            var typesUri = ApiPaths.Catalog.GetAllTypes(_remoteServiceBaseUrl);
            var dataString = await _client.GetStringAsync(typesUri);
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value=null,
                    Text="All",
                    Selected = true
                }
            };

            var data = JArray.Parse(dataString);
            foreach (var type in data)
            {
                items.Add(new SelectListItem
                {
                    Value = type.Value<string>("Id"),
                    Text = type.Value<string>("type")
                });
            }
            return items;
        }

    }
}
