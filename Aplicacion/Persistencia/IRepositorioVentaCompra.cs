using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioVentaCompra
    {
        // Metodos Venta
        void CalcularVenta();
        void RVentaConsola();
        void RVentaControl();
        void RVentaVideojuego();
        void RegistrarVentaTotal();

        // Metodos Compra
        void CalcularCompra();
		void RCompraConsola();
		void RCompraControl();
		void RCompraVideojuego();
		void RegistrarCompraTotal();
    }
}