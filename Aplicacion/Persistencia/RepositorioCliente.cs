using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioCliente : IRepositorioCliente

    {
        private readonly Conexion _appContext;
        public RepositorioCliente(Conexion appContext)
        {
	        _appContext=appContext;
        }
    

        Cliente IRepositorioCliente.addCliente(Cliente cliente)
        {
            var new_cliente = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return new_cliente.Entity;
        }

        void IRepositorioCliente.deleteCliente(int ClienteId)
        {
            var ClienteEncontrada = _appContext.Clientes.FirstOrDefault( c=> c.ClienteId
            == ClienteId);
          
             if  (ClienteEncontrada==null)
                return;
                _appContext.Remove(ClienteEncontrada);
                _appContext.SaveChanges();        
        }

        Cliente IRepositorioCliente.readCliente(int ClienteId)
        {
            return _appContext.Clientes.FirstOrDefault( c=> c.ClienteId
            == ClienteId);
        }

        Cliente IRepositorioCliente.updateCliente(Cliente cliente)
        {
            var ClienteEncontrada = _appContext.Clientes.FirstOrDefault( c=> c.ClienteId
            == cliente.ClienteId);

            if(ClienteEncontrada!=null){
	        ClienteEncontrada.Nombres = cliente.Nombres;
            ClienteEncontrada.Apellidos = cliente.Apellidos;
            ClienteEncontrada.TipoDocumento = cliente.TipoDocumento;
            ClienteEncontrada.NumeroDocumento=cliente.NumeroDocumento;
	        ClienteEncontrada.Email = cliente.Email;
	        _appContext.SaveChanges();
        }
            return ClienteEncontrada;
        }
    }
}