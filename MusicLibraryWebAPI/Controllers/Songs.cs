using Microsoft.AspNetCore.Mvc;
using MusicLibraryWebAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
public class MusicLibraryWebAPIController : Controller
{
    private readonly ApplicationDbContext _context;
    public MusicLibraryWebAPIController(ApplicationDbContext context)
    {
        _context = context;
    }
}

namespace MusicLibraryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Songs : ControllerBase
    {
        // GET: api/<Songs>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var songs = _context.Songs.ToList();
            return songs.Select(songs => $"{ songs.Title} by {songs.Artist}");
        }

        // GET api/<Songs>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            return "value";
        }

        // POST api/<Songs>
        [HttpPost]
        public void Post([FromBody] Songs newSong)
        {
            _context.Songs.Add(newSong);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = newSong.Id }, newSong);
        }

        // PUT api/<Songs>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Songs updatedSong)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            song.Title = updatedSong.Title;
            song.Artist = updatedSong.Artist;
            song.Album = updatedSong.Album;
            song.ReleaseDate = updatedSong.ReleaseDate;
            song.Genre = updatedSong.Genre;

            _context.SvaeChanges();
            return Ok(song);
        }

        // DELETE api/<Songs>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
