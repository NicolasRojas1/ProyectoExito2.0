using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioVideojuego
    {
        Videojuego addVideojuego(Videojuego videojuego);
        Videojuego readVideojuego(int VideojuegoId);
        Videojuego updateVideojuego(Videojuego videojuego);
        void deleteVideojuego(int VideojuegoId);
    }
}