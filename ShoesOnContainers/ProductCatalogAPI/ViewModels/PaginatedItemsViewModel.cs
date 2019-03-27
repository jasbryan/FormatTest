﻿using ProductCatalogAPI.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.ViewModels
{
    public class PaginatedItemsViewModel
    {
        public long Count { get; set; }

        public int PageSize { get; set; }

        public int PageIndex { get; set; }

        public IEnumerable<CatalogItem> Data { get; set; }


    }
}
