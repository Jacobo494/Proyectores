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

            //Proyectores proyector = new Proyectores()
            //{
            //    Id = 1,
            //    Marca = "Epson",
            //    Modelo = "XLight",
            //    NumeroDeSerie = "123456",
            //    situacion = SituacionProyector.Bueno,
            //    FechaDeAlta = DateTime.Now
            //};

            var modelo = LoadData();
            //var modelo = new List<Proyectores>();

            return View(modelo);
        }

        private IEnumerable<Proyectores> LoadData()
        { 
        var proyectores = new List<Proyectores>();

            proyectores.Add(new Proyectores()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "XLight",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyectores()
            {
                Id = 2,
                Marca = "LG",
                Modelo = "XLig574",
                NumeroDeSerie = "123788",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyectores()
            {
                Id = 3,
                Marca = "Sony",
                Modelo = "VPL-XW5000",
                NumeroDeSerie = "123999",
                Situacion = SituacionProyector.Regular,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyectores()
            {
                Id = 4,
                Marca = "Samsung",
                Modelo = "XLig874",
                NumeroDeSerie = "15789",
                Situacion = SituacionProyector.Malo,
                FechaDeAlta = DateTime.Now
            });
            proyectores.Add(new Proyectores()
            {
                Id = 5,
                Marca = "Panasonic",
                Modelo = "X4874",
                NumeroDeSerie = "178921",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            });


            return proyectores;
        }

        public IActionResult Create()
        {
            return View();
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
