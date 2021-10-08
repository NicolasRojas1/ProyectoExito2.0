using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioAdministradorVentas
    {
         AdministradorVenta addAVentas(AdministradorVenta AVentas);
         AdministradorVenta readAVentas(int AdministradorVentaId);
         AdministradorVenta updateAVentas(AdministradorVenta AVentas);
         void deleteAVentas(int AdministradorVentaId);
    }
}