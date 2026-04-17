using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Uso de ViewData / ViewBag / modelo de la vista

            //ViewData["Id"] = 1;
            //ViewData["Marca"] = "Epson";
            //ViewData["Modelo"] = "XLight";
            //ViewData["NumeroDeSerie"] = 123456;
            //ViewData["Situacion"] = "Bueno";
            //ViewData["FechaDeAlta"] = DateTime.Now.ToString("d");

            //ViewBag.Id = 2;
            //ViewBag.Marca = "Epson";
            //ViewBag.Modelo = "XLight";
            //ViewBag.NumeroDeSerie = 123456;
            //ViewBag.Situacion = "Bueno";
            //ViewBag.FechaDeAlta = DateTime.Now.ToString("d");

            Proyectores proyector = new Proyectores()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            };

           
            return View(proyector);
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
