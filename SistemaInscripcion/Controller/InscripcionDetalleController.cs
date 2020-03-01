using SistemaInscripcion.Data;
using SistemaInscripcion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaInscripcion.Controller
{
    public class InscripcionDetalleController
    {
        public List<InscripcionDetalle> GetInscripcions(Expression<Func<InscripcionDetalle, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<InscripcionDetalle> lista;

            try
            {
                lista = contexto.InscripcionDetalles.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
        public InscripcionDetalle Buscar(int id)
        {
            Contexto contexto = new Contexto();
            InscripcionDetalle inscripcion = new InscripcionDetalle();
            try
            {
                inscripcion = contexto.InscripcionDetalles.Find(id);

            }
            catch (Exception)
            {

                throw;
            }
            return inscripcion;
        }
    } 
}
