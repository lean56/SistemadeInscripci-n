using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Models
{
    public class Pagos
    {
        [Key]
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteId { get; set; }
        [Required]
        [Range(minimum:0,maximum:1000000,ErrorMessage ="El Monto debe se mayor que 0 ")]
        public int Monto { get; set; }
        public Pagos()
        {
            PagoId = 0;
            Fecha = DateTime.Now;
            EstudianteId = 0;
            Monto = 0;
        }
    }
}
