using System.ComponentModel.DataAnnotations;

namespace Angel_Morel_Ap_Ap1.Modelo
{
    public class Modelo
    {
        public class RegistroAportes
        {
            [Key]
            public int SistemaId { get; set; }

            [Required(ErrorMessage = "El Campo Descripción es obligatorio ")]
            public string Descripcion { get; set; }

            [Required(ErrorMessage = "El Campo Descripción es obligatorio ")]
            public string Complejidad { get; set; }
        }
    }
}
