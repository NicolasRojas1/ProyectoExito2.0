using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioVideojuegocs: IRepositorioVideojuego
    {
        private readonly Conexion _appContext;
        public RepositorioVideojuegocs(Conexion appContext){
	        _appContext=appContext;
        }

        Videojuego IRepositorioVideojuego.addVideojuego(Videojuego videojuego)
        {
            var new_videojuego = _appContext.Videojuegos.Add(videojuego);
            _appContext.SaveChanges();
            return new_videojuego.Entity;
        }

        void IRepositorioVideojuego.deleteVideojuego(int VideojuegoId)
        {
            var VideojuegoEncontrada = _appContext.Videojuegos.FirstOrDefault( vj=> vj.VideojuegoId
            == VideojuegoId);
          
             if  (VideojuegoEncontrada==null)
                return;
                _appContext.Remove(VideojuegoEncontrada);
                _appContext.SaveChanges();
        }

        Videojuego IRepositorioVideojuego.readVideojuego(int VideojuegoId)
        {
            return _appContext.Videojuegos.FirstOrDefault( vj=> vj.VideojuegoId
            == VideojuegoId);
        }

        Videojuego IRepositorioVideojuego.updateVideojuego(Videojuego videojuego)
        {
            var VideojuegoEncontrada = _appContext.Videojuegos.FirstOrDefault( vj=> vj.VideojuegoId
            == videojuego.VideojuegoId);
            if(VideojuegoEncontrada!=null){
	        VideojuegoEncontrada.Nombre = videojuego.Nombre;
            VideojuegoEncontrada.Version = videojuego.Version;
            VideojuegoEncontrada.Fabricante = videojuego.Fabricante;
            VideojuegoEncontrada.Multiplataforma = videojuego.Multiplataforma;
            VideojuegoEncontrada.PrecioCompra = videojuego.PrecioCompra;
            VideojuegoEncontrada.PrecioVenta = videojuego.PrecioVenta;
            
	        _appContext.SaveChanges();
        }
         return VideojuegoEncontrada;
        }
        
    }
}