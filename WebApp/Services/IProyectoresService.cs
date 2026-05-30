using WebApp.Models;

namespace WebApp.Services
{
    public interface IproyectoresService
    {
        IEnumerable<Proyectores> GetProyectores();
        void AddProyectores(Proyectores proyectores);
        void Update(Proyectores proyectores);
        void Delete(int id);
    }
}
