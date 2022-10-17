using Estudo_MVC_ASP.NET.Context;
using Estudo_MVC_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_MVC_ASP.NET.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
           _context = context;
        }
        

        public IActionResult Index()
        {
            var contatos = _context.Contato.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Contato.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }
    }
}
