namespace Persistencia
{
    public interface IRespositorioEmpleados
    {
        // Metodo del vendedor
        public void GenerarReporteVenta();
        // Metodo del AdCompra
        public void GenerarReporteCompra();
        // Metodo del AdSistema
        public void RegistrarEmpleado();
        // Metodo del AdVenta
        public void VerReporte();
    }
}