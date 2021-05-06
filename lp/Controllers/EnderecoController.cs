using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraDataImob.Models;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Authorization;

namespace CalculadoraDataImob.Controllers
{
    public class EnderecoController : Controller
    {
       

        private readonly EnderecosContext _context;

        public EnderecoController(EnderecosContext context)
        {
            _context = context;
        }

       

        // GET: Home
        public async Task<IActionResult> Index()
        {
            return View(await _context.EnderecosModels.ToListAsync());
        }

        [Authorize]
        // GET: Data
        public IActionResult Enderecos()
        {
            // const string script = "select * from view_base_endereco_bairro ";
            const string script = "select * from view_base_endereco_bairro ";
            var enderecos = _context.EnderecosModels
                .FromSqlRaw(script)
                .ToList();

            return Json(enderecos);

        }


        // GET: Widget
        public IActionResult Widget()
        {
            return View("/v");

        }




    }

}
