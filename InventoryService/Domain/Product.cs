using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.InventoryService.Domain
{
    public class Product : EntityBase
    {
        public Product()
        {
            ProductBrands = new List<ProductBrand>();
        }
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }

        public IEnumerable<ProductBrand> ProductBrands { get; set; }
    }
}
