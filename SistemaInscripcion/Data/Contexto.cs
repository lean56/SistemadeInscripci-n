using Microsoft.EntityFrameworkCore;
using SistemaInscripcion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaInscripcion.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Inscripcion> Inscripcion { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Asignaturas>Asignaturas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Database/InscripcionDb.db");
        }
    }
}
