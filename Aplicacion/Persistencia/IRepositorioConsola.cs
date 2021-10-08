using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioConsola
    {
        Consola1 addConsola(Consola1 consola1);
        Consola1 readConsola(int ConsolaId);
        Consola1 updateConsola(Consola1 consola1);
        void deleteConsola(int ConsolaId);  
    }
}