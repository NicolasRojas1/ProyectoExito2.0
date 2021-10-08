using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class AdicionDeTablasReporteYVentas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleadosprof");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropColumn(
                name: "IdEmpleado",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "IdVendedor",
                table: "Vendedores");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IdAdVenta",
                table: "AdministradoresVentas");

            migrationBuilder.DropColumn(
                name: "IdEmpleado",
                table: "AdministradoresVentas");

            migrationBuilder.DropColumn(
                name: "IdAdSistema",
                table: "AdministradoresSistemas");

            migrationBuilder.DropColumn(
                name: "IdEmpleado",
                table: "AdministradoresSistemas");

            migrationBuilder.DropColumn(
                name: "IdAdCompra",
                table: "AdministradoresCompras");

            migrationBuilder.DropColumn(
                name: "IdEmpleado",
                table: "AdministradoresCompras");

            migrationBuilder.CreateTable(
                name: "Reportes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reportes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: true),
                    CantConsola = table.Column<int>(type: "int", nullable: true),
                    CantControl = table.Column<int>(type: "int", nullable: true),
                    CantVideojuego = table.Column<int>(type: "int", nullable: true),
                    FechaCompraAlmacen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVentaCliente = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reportes");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.AddColumn<int>(
                name: "IdEmpleado",
                table: "Vendedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVendedor",
                table: "Vendedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAdVenta",
                table: "AdministradoresVentas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpleado",
                table: "AdministradoresVentas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAdSistema",
                table: "AdministradoresSistemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpleado",
                table: "AdministradoresSistemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAdCompra",
                table: "AdministradoresCompras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEmpleado",
                table: "AdministradoresCompras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoRol = table.Column<int>(type: "int", nullable: false),
                    NombreRol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleadosprof",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoEmpleado = table.Column<int>(type: "int", nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolEmpleadoId = table.Column<int>(type: "int", nullable: true),
                    Sucursal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleadosprof", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleadosprof_Roles_RolEmpleadoId",
                        column: x => x.RolEmpleadoId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleadosprof_RolEmpleadoId",
                table: "Empleadosprof",
                column: "RolEmpleadoId");
        }
    }
}
