using System.ComponentModel.DataAnnotations;

namespace Angel_Morel_Ap_Ap1.Models
{
    public class Aporte
    {
        [Key]
        public int AporteId { get; set; }
        [Required(ErrorMessage = "La descripción es un campo requerido")]
        public string Observacion { get; set; }
        [Required(ErrorMessage = "La descripción es un campo requerido")]
        public decimal Monto { get; set; }
        [Required(ErrorMessage = "La descripción es un campo requerido")]
        public string Persona { get; set; }
        [Required(ErrorMessage = "La descripción es un campo requerido")]
        public DateTime Fecha { get; set; }
    }
}