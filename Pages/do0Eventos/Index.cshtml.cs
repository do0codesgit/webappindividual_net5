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
    public class IndexModel : PageModel
    {
        private readonly do0.Data.do0EventoContext _context;

        public IndexModel(do0.Data.do0EventoContext context)
        {
            _context = context;
        }

        public IList<do0Evento> do0Evento { get;set; }

        public async Task OnGetAsync()
        {
            do0Evento = await _context.do0Eventos.ToListAsync();
        }
    }
}
