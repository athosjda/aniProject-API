using Anime.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Anime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AiredController
    {
        private readonly AppDbContext _db;

        public AiredController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<List<AiredTable>> GetAll()
        {
            return _db.Aired.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<AiredTable> Get(int id)
        {
            return _db.Aired
                .Where(aired => aired.AiredId == id)
                .FirstOrDefault();
        }

        [HttpPost]
        public void Update(AiredTable aired)
        {
            _db.Aired.Update(aired);
            _db.SaveChanges();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            AiredTable aired = _db.Aired.Where(aired => aired.AiredId == id).FirstOrDefault();
            if(aired.AiredId == id)
            {
                _db.Aired.Remove(aired);
                _db.SaveChanges();
            }
        }
    }
}
