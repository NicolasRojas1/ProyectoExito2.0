using Dominio;
using System.Collections.Generic;
namespace Persistencia
{
    public interface IRepositorioControles
    {
         Control addControl(Control control);
         Control readControl(int ControlId);
         Control updateControl(Control control);
         void deleteControl(int ControlId);
    }
    
}