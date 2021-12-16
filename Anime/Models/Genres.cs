using System.ComponentModel.DataAnnotations;

namespace Anime.Models
{
    public class Genres
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
