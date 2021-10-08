using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioProducto
    {
         Producto addProducto(Producto producto);
        Producto readProducto(int ProductoId);
        Producto updateProducto(Producto producto);
         void deleteProducto(int ProductoId);
    }
}