using Microsoft.EntityFrameworkCore; 
using Dominio;

namespace Persistencia   
{
    public class Conexion : DbContext
    {
        public DbSet<AdministradorCompra> AdministradoresCompras {get; set;}
        public DbSet<AdministradorSistema> AdministradoresSistemas {get; set;}
        public DbSet<AdministradorVenta> AdministradoresVentas {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Vendedor> Vendedores {get; set;}
        public DbSet<Consola1> Consolas {get; set;}
        public DbSet<Control> Controles {get; set;}
        public DbSet<Videojuego> Videojuegos {get; set;}
        public DbSet<Producto> Productos {get; set;}
        public DbSet<ArchivoReporte> ArchivoReportes {get; set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder conn)
        {
            if(!conn.IsConfigured)
            {
                conn.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = Exito2");
            }
        }
    }
}