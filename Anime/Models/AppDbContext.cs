using Microsoft.EntityFrameworkCore;

namespace Anime.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AnimeTable> Animes { get; set; }
    }
}
