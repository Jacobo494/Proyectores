using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Proyectores
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Marca")] //---obligatorio para llenar un campo 
        [StringLength(24)] //----limite de caracteristicas
     
        public string Marca { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Numero De Serie")]
        public string NumeroDeSerie { get; set; }
        public SituacionProyector Situacion { get; set; } = SituacionProyector.Bueno;
        public DateTime FechaDeAlta { get; set; } = DateTime.Now;
        public DateTime? FechaDeBaja { get; set; } = null;

    }
    public enum SituacionProyector
    {
        Bueno = 1,
        Regular,
        Malo
    }
}
