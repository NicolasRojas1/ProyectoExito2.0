using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class NuevaTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reportes");

            migrationBuilder.RenameColumn(
                name: "FechaVentaCliente",
                table: "Productos",
                newName: "FechaVenta");

            migrationBuilder.RenameColumn(
                name: "FechaCompraAlmacen",
                table: "Productos",
                newName: "FechaCompra");

            migrationBuilder.RenameColumn(
                name: "TipoControles",
                table: "Controles",
                newName: "TipoControl");

            migrationBuilder.RenameColumn(
                name: "NumeroControles",
                table: "Controles",
                newName: "NumeroControl");

            migrationBuilder.RenameColumn(
                name: "Ram",
                table: "Consolas",
                newName: "CantidadRam");

            migrationBuilder.CreateTable(
                name: "ArchivoReportes",
                columns: table => new
                {
                    ArchivoReporteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lista = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchivoReportes", x => x.ArchivoReporteId);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoCompraProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compras_Productos_ProductoCompraProductoId",
                        column: x => x.ProductoCompraProductoId,
                        principalTable: "Productos",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProductoCompraProductoId",
                table: "Compras",
                column: "ProductoCompraProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchivoReportes");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.RenameColumn(
                name: "FechaVenta",
                table: "Productos",
                newName: "FechaVentaCliente");

            migrationBuilder.RenameColumn(
                name: "FechaCompra",
                table: "Productos",
                newName: "FechaCompraAlmacen");

            migrationBuilder.RenameColumn(
                name: "TipoControl",
                table: "Controles",
                newName: "TipoControles");

            migrationBuilder.RenameColumn(
                name: "NumeroControl",
                table: "Controles",
                newName: "NumeroControles");

            migrationBuilder.RenameColumn(
                name: "CantidadRam",
                table: "Consolas",
                newName: "Ram");

            migrationBuilder.CreateTable(
                name: "Reportes",
                columns: table => new
                {
                    ReporteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reportes", x => x.ReporteId);
                });
        }
    }
}
