using Dominio;
using System.Collections.Generic;


namespace Persistencia
{
    public interface IRepositorioAdmiSistema
    {
        
        AdministradorSistema addAdministradorSistema(AdministradorSistema administradorSistema);
        AdministradorSistema readAdministradorSistema(int AdministradorSistemaId);
        AdministradorSistema updateAdministradorSistema(AdministradorSistema administradorSistema);
        void deleteAdministradorSistema(int AdministradorSistemaId);
         
    }
}
