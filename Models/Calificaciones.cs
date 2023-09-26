using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication5.Models
{
    public class Calificaciones
    {
        public class Calificacion
        {
            public String Id_Calificacion { get; set; }

            [Required]
            public string Id_Estudiante { get; set; }

            [Required]
            public string Id_Asignatura { get; set; }

            [Required]
            [Range(0, 100)]
            [Display(Name = "Nota 1")]
            public int Nota1 { get; set; }

            [Required]
            [Range(0, 100)]
            [Display(Name = "Nota 2")]
            public int Nota2 { get; set; }

            [Required]
            [Range(0, 100)]
            [Display(Name = "Nota Final")]
            public int NotaFinal { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Fecha de Registro")]
            public DateTime FechaRegistro { get; set; }

            [Display(Name = "Observaciones")]
            public string Observaciones { get; set; }

            // Otras propiedades de la calificación
        }

    }
}
