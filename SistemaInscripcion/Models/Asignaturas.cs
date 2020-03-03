using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Models
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        [Required(ErrorMessage ="Debes ingresar el codigo")]
        public string Codigo { get; set; }
        [Required(ErrorMessage ="Debe ingresar la descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Debes ingresar el Pre-requisito")]
        public string PreRequisito { get; set; }
        [Required]
        [Range(minimum:1,maximum:5,ErrorMessage ="Los creditos deben ser de 1 a 5")]
        public int Creditos { get; set; }
        public Asignaturas()
        {
            AsignaturaId = 0;
            Codigo = string.Empty;
            Descripcion = string.Empty;
            PreRequisito = string.Empty;
            Creditos = 0;
        }
    }
}
