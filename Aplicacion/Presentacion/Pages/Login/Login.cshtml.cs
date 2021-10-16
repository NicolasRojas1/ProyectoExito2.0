using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Presentacion.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public String Usuario { get; set; }

        [BindProperty]
        public String Contrasena { get; set; }

        [BindProperty]
        public String Mensaje { get; set; }
        
        [BindProperty]
        public String Mensaje2 { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Conexion conexion = new Conexion();
            Empleado empleado = conexion.Empleados.FirstOrDefault(e => e.Usuario == Usuario);

            if(empleado != null){
                if (empleado.Contraseña.Equals(Contrasena))
                {
                    return RedirectToPage("../Index");
                }else{
                    Mensaje2 = "El password no coincide";
                    // Problema con el return: en el return el profe lo ponia asi "return Pages();" y daba error sobre algo del "namespace Presentacion.Pages"
                    return null;
                }
            }else{
                Mensaje = "Usuario no ha sido encontrado";
                // Problema con el return: en el return el profe lo ponia asi "return Pages();" y daba error sobre algo del "namespace Presentacion.Pages"
                return null;
            }
        }
    }
}
