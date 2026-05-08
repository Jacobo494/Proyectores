using WebApp.Models;

namespace WebApp.Services
{

    public class ProyectoresEnMemoryService : IProyectoresService
    {
        private static List<Proyectores> _proyectores = LoadData();

        public void AddProyector(Proyectores proyector)
        {
            if (proyector != null)
            {
                _proyectores.Add(proyector);
            }
        }

        public IEnumerable<Proyectores> GetAll()
        {
            return _proyectores;
        }

        private static List<Proyectores> LoadData()
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
    }
}