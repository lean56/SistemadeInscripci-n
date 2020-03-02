﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaInscripcion.Data;

namespace SistemaInscripcion.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("SistemaInscripcion.Models.Asignaturas", b =>
                {
                    b.Property<int>("AsignaturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Creditos")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("PreRequisito")
                        .HasColumnType("TEXT");

                    b.HasKey("AsignaturaId");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("SistemaInscripcion.Models.Estudiantes", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Balance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Matricula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("SistemaInscripcion.Models.Inscripcion", b =>
                {
                    b.Property<int>("InscripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Disponible")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Limite")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Semestre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tomados")
                        .HasColumnType("INTEGER");

                    b.HasKey("InscripcionId");

                    b.ToTable("Inscripcion");
                });

            modelBuilder.Entity("SistemaInscripcion.Models.InscripcionDetalle", b =>
                {
                    b.Property<int>("InscripcionDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AsignaturaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Creditos")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescripcionAsignatura")
                        .HasColumnType("TEXT");

                    b.Property<int>("InscripcionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Subtotal")
                        .HasColumnType("INTEGER");

                    b.HasKey("InscripcionDetalleId");

                    b.HasIndex("InscripcionId");

                    b.ToTable("InscripcionDetalles");
                });

            modelBuilder.Entity("SistemaInscripcion.Models.Pagos", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.HasKey("PagoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("SistemaInscripcion.Models.InscripcionDetalle", b =>
                {
                    b.HasOne("SistemaInscripcion.Models.Inscripcion", null)
                        .WithMany("Detalles")
                        .HasForeignKey("InscripcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
