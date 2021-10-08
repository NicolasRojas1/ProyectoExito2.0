using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Actualizarid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Productos_ProductoVentaId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Videojuegos",
                newName: "VideojuegoId");

            migrationBuilder.RenameColumn(
                name: "ProductoVentaId",
                table: "Ventas",
                newName: "ProductoVentaProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_ProductoVentaId",
                table: "Ventas",
                newName: "IX_Ventas_ProductoVentaProductoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendedores",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reportes",
                newName: "ReporteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Productos",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Controles",
                newName: "ControlId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consolas",
                newName: "ConsolaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AdministradoresVentas",
                newName: "AdministradorVentaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AdministradoresSistemas",
                newName: "AdministradorSistemaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AdministradoresCompras",
                newName: "AdministradorCompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Productos_ProductoVentaProductoId",
                table: "Ventas",
                column: "ProductoVentaProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Productos_ProductoVentaProductoId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "VideojuegoId",
                table: "Videojuegos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductoVentaProductoId",
                table: "Ventas",
                newName: "ProductoVentaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_ProductoVentaProductoId",
                table: "Ventas",
                newName: "IX_Ventas_ProductoVentaId");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Vendedores",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ReporteId",
                table: "Reportes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Productos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ControlId",
                table: "Controles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ConsolaId",
                table: "Consolas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AdministradorVentaId",
                table: "AdministradoresVentas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AdministradorSistemaId",
                table: "AdministradoresSistemas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AdministradorCompraId",
                table: "AdministradoresCompras",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Productos_ProductoVentaId",
                table: "Ventas",
                column: "ProductoVentaId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
