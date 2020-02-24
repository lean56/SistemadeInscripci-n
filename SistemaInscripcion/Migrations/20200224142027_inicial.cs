using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaInscripcion.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    InscripcionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstudianteId = table.Column<int>(nullable: false),
                    Semestre = table.Column<string>(nullable: true),
                    Limite = table.Column<int>(nullable: false),
                    Tomados = table.Column<int>(nullable: false),
                    Disponible = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Monto = table.Column<int>(nullable: false),
                    Balance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.InscripcionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscripcion");
        }
    }
}
