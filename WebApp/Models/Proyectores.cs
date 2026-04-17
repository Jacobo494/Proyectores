namespace WebApp.Models
{
    public class Proyectores
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroDeSerie { get; set; }
        public SituacionProyector situacion{ get; set; }
        public DateTime FechaDeAlta { get; set; }
        public DateTime? FechaDeBaja { get; set; }

    }
    public enum SituacionProyector
    {
        Bueno,
        Regular,
        Malo
    }
}
