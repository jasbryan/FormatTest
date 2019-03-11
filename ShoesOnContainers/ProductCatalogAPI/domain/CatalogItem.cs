using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.domain
{
    public class CatalogItem
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public decimal Price { get; set; }

        public String PictureUrl { get; set; }

        public String Description { get; set; }




        //External Ids
        public int CatalogTypeId { get; set; }

        public int CatalogBrandId { get; set; }

        public virtual CatalogType CatalogType { get; set; }

        public virtual CatalogBrand CatalogBrand { get; set; }




    }
}
