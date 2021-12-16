using Anime.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Anime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController
    {
        private readonly AppDbContext _db;
        public GenreController(AppDbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public ActionResult<List<GenreTable>> GetAll()
        {
            return _db.Genres.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<GenreTable> Get(int id)
        {
            return _db.Genres.Where(genre => genre.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public void Update(GenreTable genre)
        {
            if (genre != null)
            {
                _db.Genres.Update(genre);
                _db.SaveChanges();
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            GenreTable genre = _db.Genres.Where(g => g.Id == id).FirstOrDefault();
            if(genre.Id == id)
            {
                _db.Genres.Remove(genre);
                _db.SaveChanges();
            }
        }
    }
}
