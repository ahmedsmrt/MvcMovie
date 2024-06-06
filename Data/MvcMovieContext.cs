// Data/MvcMovieContext.cs
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = null!;
        // Alternatively, you can make it nullable:
        // public DbSet<MvcMovie.Models.Movie>? Movie { get; set; }
    }
}
