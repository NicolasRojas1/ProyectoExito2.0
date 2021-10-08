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
    public class IndexModel : PageModel
    {
        private readonly Persistencia.Conexion _context;

        public IndexModel(Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<AdministradorCompra> AdministradorCompra { get;set; }

        public async Task OnGetAsync()
        {
            AdministradorCompra = await _context.AdministradoresCompras.ToListAsync();
        }
    }
}
