using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMgmt702000.CatalogueService.Controllers.v2
{
    [ApiVersion("2.0",Deprecated = false)]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
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
        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult Get()
        {
            string returnValue = new string($"you are in version v2 API");
            return Ok(returnValue);
        }
        [MapToApiVersion("2.0")]
        [HttpGet("{category}")]
        public void GetCategory(string category)
        {
            //Returns all the products which falls under given category...
        }
        [MapToApiVersion("2.0")]
        [HttpGet("{subcategory}")]
        public void GetSubCategory(string subcategory)
        {
            //Returns all the products which falls under given subcategory...
        }
        [MapToApiVersion("2.0")]
        [HttpGet("{product}")]
        public void GetProdut(string product)
        {
            //Returns a product that falls under given product...
        }
    }
}
