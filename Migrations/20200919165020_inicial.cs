using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonaBlazor.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(maxLength: 40, nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
