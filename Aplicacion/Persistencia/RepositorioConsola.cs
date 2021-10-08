using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioConsola : IRepositorioConsola
    {
        private readonly Conexion _appContext;
        public RepositorioConsola(Conexion appContext){
	        _appContext=appContext;

        }
        Consola1 IRepositorioConsola.addConsola(Consola1 consola1)
        {
            var new_consola = _appContext.Consolas.Add(consola1);
            _appContext.SaveChanges();
            return new_consola.Entity;
        }
        void IRepositorioConsola.deleteConsola(int Consola1Id)
        {
            var ConsolaEncontrada = _appContext.Consolas.FirstOrDefault( con=> con.Consola1Id
            == Consola1Id);
          
             if  (ConsolaEncontrada==null)
                return;
                _appContext.Remove(ConsolaEncontrada);
                _appContext.SaveChanges();
        }
        Consola1 IRepositorioConsola.readConsola(int Consola1Id)
        {
            return _appContext.Consolas.FirstOrDefault(con=> con.Consola1Id
            == Consola1Id);
        }
        Consola1 IRepositorioConsola.updateConsola(Consola1 consola1)
        {
            var ConsolaEncontrada = _appContext.Consolas.FirstOrDefault( con=> con.Consola1Id
            == consola1.Consola1Id);

            if(ConsolaEncontrada!=null){
	        ConsolaEncontrada.Nombre = consola1.Nombre;
            ConsolaEncontrada.Version = consola1.Version;
            ConsolaEncontrada.Fabricante = consola1.Fabricante;
            ConsolaEncontrada.CapacidadAlmacenamiento = consola1.CapacidadAlmacenamiento;
            ConsolaEncontrada.SSD = consola1.SSD;
            ConsolaEncontrada.HDD = consola1.HDD;
            ConsolaEncontrada.CantidadRam = consola1.CantidadRam;
            ConsolaEncontrada.VelocidadProcesador = consola1.VelocidadProcesador;
            ConsolaEncontrada.PrecioCompra = consola1.PrecioCompra;
            ConsolaEncontrada.PrecioVenta = consola1.PrecioVenta;

	        _appContext.SaveChanges();
        }
            return ConsolaEncontrada;
        }
    }
}