using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace presentacion.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario {get;set;}
        [BindProperty]
        public string Contrasena {get;set;}
        [BindProperty]
        public string MensajePassword {get;set;}
         [BindProperty]
        public string MensajeUsuario {get;set;}
        public void OnGet()
        {

        }

        public IActionResult OnPost(){
            Conexion conexion = new Conexion();
            Empleado empleado = conexion.Empleado.FirstOrDefault(e => e.Usuario == Usuario);
            if(empleado !=null){
                if(empleado.Contrasena.Equals(Contrasena)){
                    return RedirectToPage("../Index");
                }
                else{
                        MensajePassword = "El Password no coincide";
                        return Page();
                }
            }else{
                MensajeUsuario = "Usuario no ha sido encontrado";
                return Page();
            }
            }
           

    }        
    }

