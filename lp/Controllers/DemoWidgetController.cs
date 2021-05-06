using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiDataImob.Controllers
{
    public class DemoWidgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
