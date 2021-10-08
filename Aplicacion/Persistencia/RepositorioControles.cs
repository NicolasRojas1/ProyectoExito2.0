using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioControles: IRepositorioControles
    {
        private readonly Conexion _appContext;
        public RepositorioControles(Conexion appContext){
	        _appContext=appContext;
        }

        Control IRepositorioControles.addControl(Control control)
        {
            var new_control = _appContext.Controles.Add(control);
            _appContext.SaveChanges();
            return new_control.Entity;
        }

        void IRepositorioControles.deleteControl(int ControlId)
        {
            var ControlEncontrada = _appContext.Controles.FirstOrDefault( cl=> cl.ControlId
            == ControlId);
          
             if  (ControlEncontrada==null)
                return;
                _appContext.Remove(ControlEncontrada);
                _appContext.SaveChanges();
        }

        Control IRepositorioControles.readControl(int ControlId)
        {
            return _appContext.Controles.FirstOrDefault(cl=> cl.ControlId
            == ControlId);
        }

        Control IRepositorioControles.updateControl(Control control)
        {
             var ControlEncontrada = _appContext.Controles.FirstOrDefault( cl=> cl.ControlId
            == control.ControlId);

            if(ControlEncontrada!=null){
	        ControlEncontrada.TipoControl = control.TipoControl;
            ControlEncontrada.NumeroControl = control.NumeroControl;
            ControlEncontrada.PrecioCompra = control.PrecioCompra;
            ControlEncontrada.PrecioVenta = control.PrecioVenta ;
	        _appContext.SaveChanges();
        }
            return ControlEncontrada;
        
        }
    }
}