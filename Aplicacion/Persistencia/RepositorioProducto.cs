using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private readonly Conexion _appContext;
        public RepositorioProducto(Conexion appContext){
	        _appContext=appContext;
        }
        Producto IRepositorioProducto.addProducto(Producto producto)
        {
            var new_producto = _appContext.Productos.Add(producto);
            _appContext.SaveChanges();
            return new_producto.Entity;
        }

        void IRepositorioProducto.deleteProducto(int ProductoId)
        {
            var ProductoEncontrada = _appContext.Productos.FirstOrDefault( p=> p.ProductoId
            == ProductoId);
          
             if  (ProductoEncontrada ==null)
                return;
                _appContext.Remove(ProductoEncontrada);
                _appContext.SaveChanges();
        }

        Producto IRepositorioProducto.readProducto(int ProductoId)
        {
           return _appContext.Productos.FirstOrDefault(p=> p.ProductoId
            == ProductoId);
        }

        Producto IRepositorioProducto.updateProducto(Producto producto)
        {
            var ProductoEncontrada = _appContext.Productos.FirstOrDefault( p=> p.ProductoId
            == producto.ProductoId);

            if(ProductoEncontrada!=null){
	        ProductoEncontrada.CantConsola  = producto.CantConsola ;
            ProductoEncontrada.CantControl = producto.CantControl ;
            ProductoEncontrada.CantVideojuego = producto.CantVideojuego ;
            ProductoEncontrada.FechaCompra  = producto.FechaCompra  ;
            ProductoEncontrada.FechaVenta = producto.FechaVenta   ;
        }
            return ProductoEncontrada;
        }
    }
}