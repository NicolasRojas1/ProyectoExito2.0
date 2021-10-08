using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RepositorioAdmiSistema : IRepositorioAdmiSistema
    {
        private readonly Conexion _appContext;
        public RepositorioAdmiSistema(Conexion appContext)
        {
            _appContext = appContext;
        }
        AdministradorSistema IRepositorioAdmiSistema.addAdministradorSistema(AdministradorSistema administradorSistema)
        {
            var new_administradorSistema = _appContext.AdministradoresSistemas.Add(administradorSistema);
            _appContext.SaveChanges();
            return new_administradorSistema.Entity;
        }
        void IRepositorioAdmiSistema.deleteAdministradorSistema(int AdministradorSistemaId)
        {
            var AdministradorSistemaEncontrada = _appContext.AdministradoresSistemas.FirstOrDefault( a => a.AdministradorSistemaId == AdministradorSistemaId);

            if (AdministradorSistemaEncontrada == null)
            return;
            _appContext.Remove(AdministradorSistemaEncontrada);
            _appContext.SaveChanges();
        }

        AdministradorSistema IRepositorioAdmiSistema.readAdministradorSistema(int AdministradorSistemaId)
        {
            return _appContext.AdministradoresSistemas.FirstOrDefault(ac => ac.AdministradorSistemaId == AdministradorSistemaId);
        }

        AdministradorSistema IRepositorioAdmiSistema.updateAdministradorSistema(AdministradorSistema administradorSistema)
        {
            
            var AdministradorSistemaEncontrada = _appContext.AdministradoresSistemas.FirstOrDefault( ac => ac.AdministradorSistemaId == administradorSistema.AdministradorSistemaId);
            
            if (AdministradorSistemaEncontrada != null)
            {
                AdministradorSistemaEncontrada.Nombres = administradorSistema.Nombres;
                AdministradorSistemaEncontrada.Apellidos = administradorSistema.Apellidos;
                AdministradorSistemaEncontrada.TipoDocumento = administradorSistema.TipoDocumento;
                AdministradorSistemaEncontrada.NumeroDocumento = administradorSistema.NumeroDocumento;
                AdministradorSistemaEncontrada.CodigoEmpleado = administradorSistema.CodigoEmpleado;
                AdministradorSistemaEncontrada.Sucursal = administradorSistema.Sucursal;
                AdministradorSistemaEncontrada.Usuario = administradorSistema.Usuario;
                AdministradorSistemaEncontrada.Contraseña = administradorSistema.Contraseña;
            }
            return AdministradorSistemaEncontrada;
        }

    }
    
}