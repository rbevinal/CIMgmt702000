using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.InventoryService.Domain
{
    public class ProductBrand : EntityBase
    {
        public ProductBrand()
        {
            ProductBrandModels = new List<ProductBrandModel>();
        }
        public int ProductID { get; set; } //FK
        public int MyProperty { get; set; }
        public int ProductBrandNumber { get; set; }
        public string ProductBrandName { get; set; }

        public Product Product { get; set; }

        public IEnumerable<ProductBrandModel> ProductBrandModels { get; set; }
    }
}
