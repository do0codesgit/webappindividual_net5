using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using do0.Data;
using do0.Models;

namespace do0.Pages.do0Eventos
{
    public class EditModel : PageModel
    {
        private readonly do0.Data.do0EventoContext _context;

        public EditModel(do0.Data.do0EventoContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(do0Evento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!do0EventoExists(do0Evento.do0EventoId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool do0EventoExists(int id)
        {
            return _context.do0Eventos.Any(e => e.do0EventoId == id);
        }
    }
}
