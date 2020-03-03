using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Models
{
    public class InscripcionDetalle
    {
        [Key]
        public int InscripcionDetalleId { get; set; }
        [Required]
        public int InscripcionId { get; set; }
        [Required]

        public int AsignaturaId { get; set; }
        [Required]

        public string DescripcionAsignatura { get; set; }
        [Required]

        public int Creditos { get; set; }
        [Required]

        public int Subtotal { get; set; }

        public InscripcionDetalle()
        {
            InscripcionDetalleId = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            Subtotal = 0;
            Creditos = 0;
        }
        public InscripcionDetalle(int inscripcionDetalleId, int inscripcionId, int asignaturaId, int subTotal)
        {
            InscripcionDetalleId = inscripcionDetalleId;
            InscripcionId = inscripcionId;
            AsignaturaId = asignaturaId;
            Subtotal = subTotal;
        }
    }
}
