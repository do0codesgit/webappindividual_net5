using Microsoft.EntityFrameworkCore;

namespace do0.Data
{
    public class do0EventoContext : DbContext
    {
        public do0EventoContext (
            DbContextOptions<do0EventoContext> options)
            : base(options)
        {
        }

        public DbSet<do0.Models.do0Evento> do0Eventos { get; set; }
    }
}