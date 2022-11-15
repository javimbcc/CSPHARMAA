using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CSPHARMA_DAL.Modelos;

namespace CSPHARMA.Pages.EstadoDevolucion
{
    public class DetailsModel : PageModel
    {
        private readonly CSPHARMA_DAL.Modelos.CspharmaInformacionalContext _context;

        public DetailsModel(CSPHARMA_DAL.Modelos.CspharmaInformacionalContext context)
        {
            _context = context;
        }

      public TdcCatEstadosDevolucionPedido TdcCatEstadosDevolucionPedido { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.TdcCatEstadosDevolucionPedidos == null)
            {
                return NotFound();
            }

            var tdccatestadosdevolucionpedido = await _context.TdcCatEstadosDevolucionPedidos.FirstOrDefaultAsync(m => m.CodEstadoDevolucion == id);
            if (tdccatestadosdevolucionpedido == null)
            {
                return NotFound();
            }
            else 
            {
                TdcCatEstadosDevolucionPedido = tdccatestadosdevolucionpedido;
            }
            return Page();
        }
    }
}
