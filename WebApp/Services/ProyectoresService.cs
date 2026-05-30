using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresService : IproyectoresService
    {
        private readonly AppDbContext _contexto;
        public ProyectoresService(AppDbContext contexto)
        {
            this._contexto = contexto;
        }


        public void AddProyectores(Proyectores proyectores)
        {
            if (proyectores != null)
            {
                _contexto.Proyectores.Add(proyectores);
                _contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Proyectores? GetProyectoresById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proyectores> GetProyectores()
        {
            throw new NotImplementedException();
        }

        public void Update(Proyectores proyectores)
        {
            throw new NotImplementedException();
        }
    }

    public class AppDbContext
    {
    }
}
