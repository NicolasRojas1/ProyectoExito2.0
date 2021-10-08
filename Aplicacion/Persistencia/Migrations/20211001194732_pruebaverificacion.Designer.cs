﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(Conexion))]
    [Migration("20211001194732_pruebaverificacion")]
    partial class pruebaverificacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dominio.AdministradorCompra", b =>
                {
                    b.Property<int>("AdministradorCompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministradorCompraId");

                    b.ToTable("AdministradoresCompras");
                });

            modelBuilder.Entity("Dominio.AdministradorSistema", b =>
                {
                    b.Property<int>("AdministradorSistemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministradorSistemaId");

                    b.ToTable("AdministradoresSistemas");
                });

            modelBuilder.Entity("Dominio.AdministradorVenta", b =>
                {
                    b.Property<int>("AdministradorVentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministradorVentaId");

                    b.ToTable("AdministradoresVentas");
                });

            modelBuilder.Entity("Dominio.ArchivoReporte", b =>
                {
                    b.Property<int>("ArchivoReporteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Lista")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArchivoReporteId");

                    b.ToTable("ArchivoReportes");
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Dominio.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ProductoCompraProductoId")
                        .HasColumnType("int");

                    b.HasKey("CompraId");

                    b.HasIndex("ProductoCompraProductoId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Dominio.Consola1", b =>
                {
                    b.Property<int>("Consola1Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CantidadRam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CapacidadAlmacenamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HDD")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<bool>("SSD")
                        .HasColumnType("bit");

                    b.Property<string>("VelocidadProcesador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Consola1Id");

                    b.ToTable("Consolas");
                });

            modelBuilder.Entity("Dominio.Control", b =>
                {
                    b.Property<int>("ControlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NumeroControl")
                        .HasColumnType("int");

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<string>("TipoControl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ControlId");

                    b.ToTable("Controles");
                });

            modelBuilder.Entity("Dominio.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantConsola")
                        .HasColumnType("int");

                    b.Property<int>("CantControl")
                        .HasColumnType("int");

                    b.Property<int>("CantVideojuego")
                        .HasColumnType("int");

                    b.Property<string>("FechaCompra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaVenta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Dominio.Vendedor", b =>
                {
                    b.Property<int>("VendedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendedorId");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Dominio.Venta", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ProductoVentaProductoId")
                        .HasColumnType("int");

                    b.HasKey("VentaId");

                    b.HasIndex("ProductoVentaProductoId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Dominio.Videojuego", b =>
                {
                    b.Property<int>("VideojuegoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Multiplataforma")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioCompra")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideojuegoId");

                    b.ToTable("Videojuegos");
                });

            modelBuilder.Entity("Dominio.Compra", b =>
                {
                    b.HasOne("Dominio.Producto", "ProductoCompra")
                        .WithMany()
                        .HasForeignKey("ProductoCompraProductoId");

                    b.Navigation("ProductoCompra");
                });

            modelBuilder.Entity("Dominio.Venta", b =>
                {
                    b.HasOne("Dominio.Producto", "ProductoVenta")
                        .WithMany()
                        .HasForeignKey("ProductoVentaProductoId");

                    b.Navigation("ProductoVenta");
                });
#pragma warning restore 612, 618
        }
    }
}
