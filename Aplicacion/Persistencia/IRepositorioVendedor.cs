using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioVendedor
    {
         Vendedor addVendedor(Vendedor vendedor);
        Vendedor readVendedor(int VendedorId);
         Vendedor updateVendedor(Vendedor vendedor);
         void deleteVendedor(int VendedorId);
    }
}