﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(Conexion))]
    [Migration("20211019185536_PruebaMigracion")]
    partial class PruebaMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

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

            modelBuilder.Entity("Dominio.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreRol")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrimerIngreso")
                        .HasColumnType("bit");

                    b.Property<string>("Sucursal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");
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
#pragma warning restore 612, 618
        }
    }
}
