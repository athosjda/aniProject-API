using Microsoft.EntityFrameworkCore;

namespace Anime.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AnimeTable> Animes { get; set; }
        public DbSet<AiredTable> Aired { get; set; }
        public DbSet<GenreTable> Genres { get; set; }
    }
}
