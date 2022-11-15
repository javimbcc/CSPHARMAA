using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CSPHARMA_DAL.Modelos;

namespace CSPHARMA.Pages.LineasDistribucion
{
    public class IndexModel : PageModel
    {
        private readonly CSPHARMA_DAL.Modelos.CspharmaInformacionalContext _context;

        public IndexModel(CSPHARMA_DAL.Modelos.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IList<TdcCatLineasDistribucion> TdcCatLineasDistribucion { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TdcCatLineasDistribucions != null)
            {
                TdcCatLineasDistribucion = await _context.TdcCatLineasDistribucions.ToListAsync();
            }
        }
    }
}
