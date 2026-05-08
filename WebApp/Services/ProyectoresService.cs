using WebApp.Models;

namespace WebApp.Services
{
    public interface IProyectoresService
    {
        IEnumerable<Proyectores> GetAll();
        void AddProyector(Proyectores proyector);
        
    }
}
