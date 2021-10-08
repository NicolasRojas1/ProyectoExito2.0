using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioVendedor : IRepositorioVendedor
    {
         private readonly Conexion _appContext;
        public RepositorioVendedor(Conexion appContext){
	        _appContext=appContext;
        }
        Vendedor IRepositorioVendedor.addVendedor(Vendedor vendedor)
        {
            var new_vendedor = _appContext.Vendedores.Add(vendedor);
            _appContext.SaveChanges();
            return new_vendedor.Entity;
        }

        void IRepositorioVendedor.deleteVendedor(int VendedorId)
        {
            var VendedorEncontrada = _appContext.Vendedores.FirstOrDefault( v=> v.VendedorId
            == VendedorId);
          
             if  (VendedorEncontrada==null)
                return;
                _appContext.Remove(VendedorEncontrada);
                _appContext.SaveChanges();
        }

        Vendedor IRepositorioVendedor.readVendedor(int VendedorId)
        {
            return _appContext.Vendedores.FirstOrDefault( v=> v.VendedorId
            == VendedorId);
        }

        Vendedor IRepositorioVendedor.updateVendedor(Vendedor vendedor)
        {
           var VendedorEncontrada = _appContext.Vendedores.FirstOrDefault( v=> v.VendedorId
            == vendedor.VendedorId);
            if(VendedorEncontrada!=null){
	        VendedorEncontrada.Nombres = vendedor.Nombres;
            VendedorEncontrada.Apellidos = vendedor.Apellidos;
            VendedorEncontrada.TipoDocumento = vendedor.TipoDocumento;
            VendedorEncontrada.NumeroDocumento=vendedor.NumeroDocumento;
            VendedorEncontrada.CodigoEmpleado=vendedor.CodigoEmpleado;
            VendedorEncontrada.Sucursal=vendedor.Sucursal;
            VendedorEncontrada.Usuario=vendedor.Usuario;
            VendedorEncontrada.Contraseña=vendedor.Contraseña;
	        _appContext.SaveChanges();
        }
         return VendedorEncontrada;
        }
    }
}