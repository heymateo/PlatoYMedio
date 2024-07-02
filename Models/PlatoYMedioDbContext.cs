using Microsoft.EntityFrameworkCore;
using TuProyecto.Models;

namespace PlatoYMedio.Models
{
    public class PlatoYMedioDbContext : DbContext
    {
        public PlatoYMedioDbContext(DbContextOptions<PlatoYMedioDbContext> options) : base(options) { } 
        public DbSet<Reservaciones> Reservaciones { get; set; }
    }
}
