using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RepositorioAdmiCompra : IRepositorioAdmiCompra
    {
        private readonly Conexion _appContext;
        public RepositorioAdmiCompra(Conexion appContext)
        {
            _appContext = appContext;
        }
        AdministradorCompra IRepositorioAdmiCompra.addAdministradorCompra(AdministradorCompra administradorCompra)
        {
            var new_administradorCompra = _appContext.AdministradoresCompras.Add(administradorCompra);
            _appContext.SaveChanges();
            return new_administradorCompra.Entity;
        }

        void IRepositorioAdmiCompra.deleteAdministradorCompra(int AdministradorCompraId)
        {
            var AdministradorCompraEncontrada = _appContext.AdministradoresCompras.FirstOrDefault( ac => ac.AdministradorCompraId == AdministradorCompraId);

            if (AdministradorCompraEncontrada == null)
            return;
            _appContext.Remove(AdministradorCompraEncontrada);
            _appContext.SaveChanges();
        }

        AdministradorCompra IRepositorioAdmiCompra.readAdministradorCompra(int AdministradorCompraId)
        {
            return _appContext.AdministradoresCompras.FirstOrDefault(ac => ac.AdministradorCompraId == AdministradorCompraId);
        }

        AdministradorCompra IRepositorioAdmiCompra.updateAdministradorCompra(AdministradorCompra administradorCompra)
        {
            var AdministradorCompraEncontrada = _appContext.AdministradoresCompras.FirstOrDefault( ac => ac.AdministradorCompraId == administradorCompra.AdministradorCompraId);
            
            if (AdministradorCompraEncontrada != null)
            {
                AdministradorCompraEncontrada.Nombres = administradorCompra.Nombres;
                AdministradorCompraEncontrada.Apellidos = administradorCompra.Apellidos;
                AdministradorCompraEncontrada.TipoDocumento = administradorCompra.TipoDocumento;
                AdministradorCompraEncontrada.NumeroDocumento = administradorCompra.NumeroDocumento;
                AdministradorCompraEncontrada.CodigoEmpleado = administradorCompra.CodigoEmpleado;
                AdministradorCompraEncontrada.Sucursal = administradorCompra.Sucursal;
                AdministradorCompraEncontrada.Usuario = administradorCompra.Usuario;
                AdministradorCompraEncontrada.Contraseña = administradorCompra.Contraseña;
            }
            return AdministradorCompraEncontrada;
            
        }

        
    }
}