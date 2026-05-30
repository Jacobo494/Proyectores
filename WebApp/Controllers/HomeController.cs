using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
        
    {
        private IproyectoresService _service;
        public HomeController(IproyectoresService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {

            var modelo = _service.GetProyectores();
            return View(modelo);
        }

      

        public IActionResult Create()
        {
            var modelo = new HomeCreateViewModel();
            modelo.FechDeAlta = DateTime.Now;
            return View(modelo);
        }

        [HttpPost]
        public IActionResult Create(Proyectores proyector)
        {
            if(!ModelState.IsValid)
            {
                return View(proyector);
            }
            else
            {
                _service.AddProyectores(proyector);
                return RedirectToAction(nameof(Index));
            }
        }

 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
