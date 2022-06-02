using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.CatalogueService.Domain
{
    public class ProductBrandModel : EntityBase
    {
        public int ProductBrandID { get; set; } //FK
        public int ModelNumber { get; set; }
        public string ModelName { get; set; }
        public string ModelColour { get; set; }
        public string ModelTechSpec { get; set; }
        public string ModelMake { get; set; }
        public int ModelInStock { get; set; }

        public ProductBrand ProductBrand { get; set; }
    }
}
