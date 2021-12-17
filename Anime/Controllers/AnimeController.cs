using Anime.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public List<AnimeTable> GetAll()
        {
            return _db.Animes
                .Include(an => an.AiredTable)
                .OrderByDescending(a => a.Score)
                .ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<AnimeTable> Get(int id)
        {
            AnimeTable anime = _db.Animes
                .Include(an => an.AiredTable)
                .Where(a => a.MalId == id)
                .FirstOrDefault();
            return anime.MalId == id ? anime : null;
        }

        [HttpPost]
        public void Create(AnimeTable anime)
        {
            _db.Aired.Add(anime.AiredTable);
            _db.SaveChanges();

            anime.AiredId = anime.AiredTable.AiredId;

            AiredTable aired = _db.Aired.Where(a => a.AiredId == anime.AiredId).FirstOrDefault();
            
            anime.AiredTable = aired;

            _db.Animes.Add(anime);

            _db.SaveChanges();
        }

        [HttpPut]
        public void Update(AnimeTable anime)
        {
            if (anime != null)
            {
                _db.Animes.Update(anime);
                _db.SaveChanges(true);
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            AnimeTable anime = _db.Animes
                .Include(an => an.AiredTable)
                .Where(a => a.MalId == id)
                .FirstOrDefault();

            if (anime.MalId == id)
            {
                _db.Animes.Remove(anime);
                _db.SaveChanges(true);
            }
        }
    }
}
