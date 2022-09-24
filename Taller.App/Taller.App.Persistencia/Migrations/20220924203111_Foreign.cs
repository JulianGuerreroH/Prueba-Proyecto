using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller.App.Persistencia.Migrations
{
    public partial class Foreign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mecanicos",
                columns: table => new
                {
                    mecanicoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nivelEstudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanicos", x => x.mecanicoId);
                });

            migrationBuilder.CreateTable(
                name: "Revisiones",
                columns: table => new
                {
                    revisionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fechaRev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mecanicoId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisiones", x => x.revisionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mecanicos");

            migrationBuilder.DropTable(
                name: "Revisiones");
        }
    }
}
