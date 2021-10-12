using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dominio;
using Persistencia;

namespace Presentacion.Pages.CrudConsola1
{
    public class DeleteModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public DeleteModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Consola1 Consola1 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consola1 = await _context.Consolas.FirstOrDefaultAsync(m => m.Consola1Id == id);

            if (Consola1 == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Consola1 = await _context.Consolas.FindAsync(id);

            if (Consola1 != null)
            {
                _context.Consolas.Remove(Consola1);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
