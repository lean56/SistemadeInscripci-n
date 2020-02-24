﻿using Microsoft.EntityFrameworkCore;
using SistemaInscripcion.Data;
using SistemaInscripcion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaInscripcion.Controller
{
    public class InscripncionController
    {
        public bool Insertar(Inscripcion inscripcion)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (inscripcion.InscripcionId==0)
                {
                    paso = Guardar(inscripcion);
                }
                else
                {
                    paso = Modificar(inscripcion);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

    private bool Guardar(Inscripcion inscripcion)
    {
        Contexto contexto = new Contexto();
        bool paso = false;

            try
            {
                contexto.Inscripcion.Add(inscripcion);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
    }

     private bool Modificar(Inscripcion inscripcion)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Inscripcion.Add(inscripcion);
                contexto.Entry(inscripcion).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

    public Inscripcion Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                inscripcion = contexto.Inscripcion.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return inscripcion;
        }

    public bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                inscripcion = contexto.Inscripcion.Find(id);
                contexto.Entry(inscripcion).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
    public List<Inscripcion> GetInscripcions(Expression<Func<Inscripcion, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Inscripcion> lista;

            try
            {
                lista = contexto.Inscripcion.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }


    }
}
