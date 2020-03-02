using Microsoft.EntityFrameworkCore;
using SistemaInscripcion.Data;
using SistemaInscripcion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaInscripcion.Controller
{
    public class PagosController
    {
        public bool Guardar(Pagos pago)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (pago.PagoId == 0)
                {
                   // contexto.SaveChanges();
                      paso = Insertar(pago);
                }
                else
                {
                    paso = Modificar(pago);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Pagos pago)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Estudiantes.Find(pago.EstudianteId).Balance -= pago.Monto;

                contexto.Pagos.Add(pago);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool Modificar(Pagos pago)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Pagos.Add(pago);
                contexto.Entry(pago).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Pagos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Pagos pago = new Pagos();

            try
            {
                pago = contexto.Pagos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return pago;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Pagos pago = new Pagos();

            try
            {
                pago = contexto.Pagos.Find(id);
                contexto.Entry(pago).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public List<Pagos> GetPagos(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> lista;
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Pagos.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
    }
}
