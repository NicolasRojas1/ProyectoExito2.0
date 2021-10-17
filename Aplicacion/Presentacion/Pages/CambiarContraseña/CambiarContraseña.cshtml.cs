using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
using Microsoft.AspNetCore.Http;

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
            var Username = HttpContext.Session.GetString("username");
            HttpContext.Session.Remove("username");
            Empleado empleado = conn.Empleados.FirstOrDefault(e => e.Usuario == Username);
            if(Password.Equals(RepeatPassword)){
                MensajePassword = "Las contraseñas no coinciden";
            }else
            {
                empleado.Contraseña = Password;
                empleado.PrimerIngreso = false;
                conn.SaveChanges();
            }
        }
    }
}
