using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogueService.Controllers
{
    public class CalalogueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
