﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models
{
    public class Catalog
    {
        public long Count { get; set; }

        public int PageSize { get; set; }

        public int PageIndex { get; set; }

        public List<CatalogItem> Data { get; set; }


    }
}
