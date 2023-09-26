using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication5.Models
{
    public class Estudiante
    {
        public string Id_estudiante { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Phone]
        [Display(Name = "Número de Teléfono")]
        public string NumeroTelefono { get; set; }

        [StringLength(100)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Género")]
        public string Genero { get; set; }

        [Display(Name = "Nacionalidad")]
        public string Nacionalidad { get; set; }

        [Display(Name = "Carrera")]
        public string Carrera { get; set; }



        public List<Calificacion> Calificaciones { get; set; }
    }

 

}
