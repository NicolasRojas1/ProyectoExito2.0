using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudControl
{
    public class DetailsModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public DetailsModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        public Control Control { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Control = await _context.Controles.FirstOrDefaultAsync(m => m.ControlId == id);

            if (Control == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
