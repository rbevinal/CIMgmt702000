using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet("{product}")]
        public IActionResult GetInventoryProduct(string product)
        {
            string returnValue = new string($"you are in version v1 API");
            return Ok(returnValue);
        }
    }
}
