﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication5.Models
{
    public class Asignatura
    {
        public String Id_Asignatura { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ")]
        [Display(Name = "Nombre de la Asignatura")]
        public string Nombre { get; set; }

        [Display(Name = "Código de la Asignatura")]
        public string Codigo { get; set; }
        [RegularExpression("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [RegularExpression("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ")]
        [Display(Name = "Profesor Asignado")]
        public string ProfesorAsignado { get; set; }
        [RegularExpression("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ")]
        [Display(Name = "Horario")]
        public string Horario { get; set; }
        [RegularExpression("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM ")]
        [Display(Name = "Aula")]
        public string Aula { get; set; }
        [Range(1,8)]
        [Display(Name = "Número de Créditos")]
        public int Creditos { get; set; }

        [Display(Name = "Fecha de Inicio")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha de Fin")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

    }

}
