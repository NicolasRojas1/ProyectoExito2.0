namespace Dominio 
{
	public class Producto 
	{
		public int ProductoId {get; set;}
		public int CantConsola {get; set;}
		public int CantControl {get; set;}
		public int CantVideojuego {get; set;}
		public string FechaCompra {get; set;}
		public string FechaVenta {get; set;}
		public void CalcularCompraAlmacen()
		{
		}
		public void CalcularVentaCliente()
		{
		}
	}
}