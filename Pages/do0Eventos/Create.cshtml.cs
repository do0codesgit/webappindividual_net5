using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using do0.Data;
using do0.Models;

namespace do0.Pages.do0Eventos
{
    public class CreateModel : PageModel
    {
        private readonly do0.Data.do0EventoContext _context;

        public CreateModel(do0.Data.do0EventoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public do0Evento do0Evento { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.do0Eventos.Add(do0Evento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
