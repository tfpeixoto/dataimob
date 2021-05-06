using Microsoft.AspNetCore.Mvc;

namespace ApiDataImob.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
