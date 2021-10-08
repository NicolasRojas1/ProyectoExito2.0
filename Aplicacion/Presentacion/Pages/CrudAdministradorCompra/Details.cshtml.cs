using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudAdministradorCompra
{
    public class DetailsModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public DetailsModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        public AdministradorCompra AdministradorCompra { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AdministradorCompra = await _context.AdministradoresCompras.FirstOrDefaultAsync(m => m.AdministradorCompraId == id);

            if (AdministradorCompra == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
