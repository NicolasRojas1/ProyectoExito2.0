using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace presentacion.Pages
{
    public class CambiarContraseñaModel : PageModel
    {
        [BindProperty]
        public String Password { get; set; }
        [BindProperty]
        public String RepeatPassword { get; set; }
        [BindProperty]
        public String MensajePassword { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Conexion conn = new Conexion();
            Username = HttpContext.Session.GetString("username");
            Empleado empleado = conexion.Empleados.FirstOrDefault(e => e.Usuario == Usuario);
            if(Password.Equals(RepeatPassword)){
                MensajePassword = "Las contraseñas no coinciden";
            }else
            {
                empleado.Password = Password;
                empleado.PrimerIngreso = false;
                conn.SaveChanges();
            }
        }
    }
}
