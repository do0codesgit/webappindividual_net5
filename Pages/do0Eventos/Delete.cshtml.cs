using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using do0.Data;
using do0.Models;

namespace do0.Pages.do0Eventos
{
    public class DeleteModel : PageModel
    {
        private readonly do0.Data.do0EventoContext _context;

        public DeleteModel(do0.Data.do0EventoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public do0Evento do0Evento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            do0Evento = await _context.do0Eventos.FirstOrDefaultAsync(m => m.do0EventoId == id);

            if (do0Evento == null)
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

            do0Evento = await _context.do0Eventos.FindAsync(id);

            if (do0Evento != null)
            {
                _context.do0Eventos.Remove(do0Evento);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
