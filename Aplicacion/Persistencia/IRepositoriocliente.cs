using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public  interface IRepositorioCliente
    {
         Cliente addCliente(Cliente cliente);
         Cliente readCliente(int ClienteId);
         Cliente updateCliente(Cliente cliente);
         void deleteCliente(int ClienteId);
    }
}