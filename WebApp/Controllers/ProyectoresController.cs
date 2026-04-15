using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult()
            {
                Content = 
                $"<h1>Proyectores</h1>"
                +"<p>Aqui se mostraran la lista de proyectores registrados</p>",
                ContentType = " text/html"
            };
        }

        public IActionResult Details(int id) 
        {
            return new ContentResult()
            {
                Content = $"<h1>Nuevo proyector</h1>"
                +$"Aquí se mostrara la informacion de un proyector especifico: {id} ",
                ContentType = "text/html"
            };  
        }


        public IActionResult Delete(int id)
        {
            return new ContentResult()
            {
                Content = $"<h1>Dar de baja</h1>"
                + $"Aqui se dara de baja un proyector espeficico: {id} ",
                ContentType = "text/html"
            };
        }

        public IActionResult Edit(int id)
        {
            return new ContentResult()
            {
                Content = $"<h1>Editar un proyector</h1>"
                + $"Aqui se mostrara la informacion de proyecto: {id} ",
                ContentType = "text/html"
            };
        }


    }

}
