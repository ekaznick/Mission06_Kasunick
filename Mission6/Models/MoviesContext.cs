using Microsoft.EntityFrameworkCore;

namespace Mission06_Kasunick.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
    }
}
