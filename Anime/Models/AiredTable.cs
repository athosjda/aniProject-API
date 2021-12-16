using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Anime.Models
{
    public class AiredTable
    {
        public AiredTable()
        {
            Animes = new HashSet<AnimeTable>();
        }
        [Key]
        public int AiredId { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        
        public ICollection<AnimeTable> Animes { get; set; }
    }
}
