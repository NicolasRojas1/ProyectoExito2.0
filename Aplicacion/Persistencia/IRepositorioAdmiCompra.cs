using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioAdmiCompra
    {
        AdministradorCompra addAdministradorCompra(AdministradorCompra administradorCompra);
        AdministradorCompra readAdministradorCompra(int AdministradorCompraId);
        AdministradorCompra updateAdministradorCompra(AdministradorCompra administradorCompra);
        void deleteAdministradorCompra(int AdministradorCompraId);

    }
}