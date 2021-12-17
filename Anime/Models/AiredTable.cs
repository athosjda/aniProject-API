using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Anime.Models
{
    public class AiredTable
    {
        [Key]
        public int AiredId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        
    }
}
