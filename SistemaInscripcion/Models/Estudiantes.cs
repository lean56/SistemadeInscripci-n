using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage ="Debes ingresar la matricula")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "Debes ingresar el Nombre")]
        public string Nombres { get; set; }
        public int Balance { get; set; }
        public Estudiantes()
        {
            EstudianteId = 0;
            Matricula = string.Empty;
            Nombres = string.Empty;
            Balance = 0;
        }
    }
}
