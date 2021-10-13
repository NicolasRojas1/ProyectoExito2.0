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
    public class IndexModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public IndexModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Consola1> Consola1 { get;set; }

        public async Task OnGetAsync()
        {
            Consola1 = await _context.Consolas.ToListAsync();
        }
    }
}
