using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioAVentas : IRepositorioAdministradorVentas
    {
         private readonly Conexion _appContext;
        public RepositorioAVentas(Conexion appContext){
	        _appContext=appContext;
        }
        AdministradorVenta IRepositorioAdministradorVentas.addAVentas(AdministradorVenta AVentas)
        {
            var new_AVentas = _appContext.AdministradoresVentas.Add(AVentas);
            _appContext.SaveChanges();
            return new_AVentas.Entity;
        }

        void IRepositorioAdministradorVentas.deleteAVentas(int AdministradorVentaId)
        {
            var AVentasEncontrada = _appContext.AdministradoresVentas.FirstOrDefault( AV=> AV.AdministradorVentaId
            == AdministradorVentaId);
          
             if  (AVentasEncontrada==null)
                return;
                _appContext.Remove(AVentasEncontrada);
                _appContext.SaveChanges();
        }

        AdministradorVenta IRepositorioAdministradorVentas.readAVentas(int AdministradorVentaId)
        {
            return _appContext.AdministradoresVentas.FirstOrDefault( AV=> AV.AdministradorVentaId
            == AdministradorVentaId);
        }

        AdministradorVenta IRepositorioAdministradorVentas.updateAVentas(AdministradorVenta AVentas)
        {
           var AVentasEncontrada = _appContext.AdministradoresVentas.FirstOrDefault( AV=> AV.AdministradorVentaId
            == AVentas.AdministradorVentaId);
            if(AVentasEncontrada!=null){
	        AVentasEncontrada.Nombres = AVentas.Nombres;
           AVentasEncontrada.Apellidos = AVentas.Apellidos;
            AVentasEncontrada.TipoDocumento = AVentas.TipoDocumento;
            AVentasEncontrada.NumeroDocumento=AVentas.NumeroDocumento;
            AVentasEncontrada.CodigoEmpleado=AVentas.CodigoEmpleado;
            AVentasEncontrada.Sucursal=AVentas.Sucursal;
            AVentasEncontrada.Usuario=AVentas.Usuario;
            AVentasEncontrada.Contraseña=AVentas.Contraseña;
	        _appContext.SaveChanges();
        }
         return AVentasEncontrada;
        }
        
    }
}