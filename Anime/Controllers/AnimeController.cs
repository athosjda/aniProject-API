using Anime.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Anime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController
    {
        private readonly AppDbContext _db;
        public AnimeController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<AnimeTable> Get()
        {
            return _db.Animes
                .OrderByDescending(animes => animes.Score)
                .ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<AnimeTable> Get(int id)
        {
            return _db.Animes
                .Where(anime => anime.MalId == id)
                .FirstOrDefault();
        }

        [HttpPost]
        public void Create(AnimeTable anime)
        {
            _db.Animes.Add(anime);

            _db.SaveChanges();
        }

        [HttpDelete]
        public void Destroy(int id)
        {
            AnimeTable anime = _db.Animes
                .Where(anime => anime.MalId == id)
                .FirstOrDefault();
            
            _db.Animes.Remove(anime);
            
            _db.SaveChanges();
        }
    }
}
