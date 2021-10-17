using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class MigracionValidarContraseña : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Empleados",
                newName: "Contraseña");

            migrationBuilder.AddColumn<bool>(
                name: "PrimerIngreso",
                table: "Empleados",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimerIngreso",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "Empleados",
                newName: "Password");
        }
    }
}
