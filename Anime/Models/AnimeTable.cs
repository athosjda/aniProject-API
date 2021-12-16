using System.ComponentModel.DataAnnotations;

namespace Anime.Models
{
    public class AnimeTable
    {
        [Key]
        public int MalId { get; set; }
        public string ImageUrl { get; set; }
        public string TrailerUrl { get; set; }
        public string Title { get; set; }
        public string TitleJapanese { get; set; }
        public int Episodes { get; set; }
        public double Score { get; set; }
        public string Synopsis { get; set; }
        public int AiredId { get; set; }
    }
}
