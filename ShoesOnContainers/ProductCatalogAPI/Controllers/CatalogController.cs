using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductCatalogAPI.Data;
using ProductCatalogAPI.domain;
using ProductCatalogAPI.ViewModels;

namespace ProductCatalogAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _context;

        private readonly IConfiguration _config;

        public CatalogController(CatalogContext context, IConfiguration configy)
        {
            _context = context;
            _config = configy;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogTypes()
        {
            var items = await _context.CatalogTypes.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogBrands()
        {
            var items = await _context.CatalogBrands.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Items(
            [FromQuery]int pageSize=6,
            [FromQuery]int pageIndex=0)
        {
            var total = await _context.CatalogItems.LongCountAsync();
            var items = await _context.CatalogItems
                .OrderBy(c => c.Name)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();

            items = ChangePicUrl(items);

            return Ok(new PaginatedItemsViewModel
            {
                Count = total,
                PageIndex = pageIndex,
                PageSize = pageSize,
                Data = items
            });
        }

        private List<CatalogItem> ChangePicUrl(List<CatalogItem> items)
        {
            items.ForEach(c => c.PictureUrl = c.PictureUrl.Replace("http://externalcatalogbaseurltobereplaced",
                _config["ExternalDomainUrl"]));

            return items;
        }
    }
}