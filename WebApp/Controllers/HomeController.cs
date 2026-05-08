using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class HomeController : Controller
        
    {
        private IProyectoresService _service;
        public HomeController()
        {
            _service = new ProyectoresEnMemoryService();
        }
        public IActionResult Index()
        {

            var modelo = _service.GetAll();
            return View(modelo);
        }

      

        public IActionResult Create()
        {
            Proyectores proyector = new Proyectores();
            proyector.FechaDeAlta = DateTime.Now;
            return View(proyector);

        }

        [HttpPost]
        public IActionResult Create(Proyectores proyector)
        {
            _service.AddProyector(proyector);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
