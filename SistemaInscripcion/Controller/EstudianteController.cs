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
    public class EstudianteController
    {
        public bool Guardar(Estudiantes estudiante)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (estudiante.EstudianteId == 0)
                {
                    paso = Insertar(estudiante);
                }
                else
                {
                    paso = Modificar(estudiante);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Estudiantes estudiante)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Estudiantes.Add(estudiante);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public bool Modificar(Estudiantes estudiante)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Estudiantes.Add(estudiante);
                contexto.Entry(estudiante).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public Estudiantes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Estudiantes estudiante = new Estudiantes();

            try
            {
                estudiante = contexto.Estudiantes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return estudiante;
        }

        public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Estudiantes estudiante = new Estudiantes();

            try
            {
                estudiante = contexto.Estudiantes.Find(id);
                contexto.Entry(estudiante).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public List<Estudiantes> GetEstudiantes(Expression<Func<Estudiantes, bool>> expression)
        {
            List<Estudiantes> lista;
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Estudiantes.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }


    }
}
