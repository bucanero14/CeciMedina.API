using Microsoft.EntityFrameworkCore.Migrations;

namespace CeciMedina.Data.Migrations
{
    public partial class MissingValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecioFinal",
                table: "Productos",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ExistenciaMaxima",
                table: "Inventarios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExistenciaMinima",
                table: "Inventarios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioFinal",
                table: "Inventarios",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioFinal",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ExistenciaMaxima",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "ExistenciaMinima",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "PrecioFinal",
                table: "Inventarios");
        }
    }
}
