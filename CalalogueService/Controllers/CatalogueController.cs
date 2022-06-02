using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.CatalogueService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CatalogueController : ControllerBase
    {
        private readonly ILogger<CatalogueController> _logger;

        public CatalogueController(ILogger<CatalogueController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Lists all available products.
        /// </summary>
        [HttpGet]
        public void Get()
        {
            Console.WriteLine("you are in default API");
        }

        [HttpGet("{category}")]
        public void GetCategory(string category)
        {
            //Returns all the products which falls under given category...
        }

        [HttpGet("{subcategory}")]
        public void GetSubCategory(string subcategory)
        {
            //Returns all the products which falls under given subcategory...
        }

        [HttpGet("{product}")]
        public void GetProdut(string product)
        {
            //Returns a product that falls under given product...
        }
    }
}
