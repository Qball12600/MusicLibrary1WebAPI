using Microsoft.AspNetCore.Mvc;
using MusicLibraryWebAPI.Data;
using MusicLibraryWebAPI.Models;
using MySqlX.XDevAPI.CRUD;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace MusicLibraryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        //public class MusicLibraryWebAPIController : Controller
        //{
            private readonly ApplicationDbContext _context;
             public SongsController(ApplicationDbContext context)
             {
                 _context = context;
             }



        //private readonly object _context;

        //private object _context;

        //public object Title { get; private set; }
        //public object Artist { get; private set; }
        //public object Album { get; private set; }
        //public object ReleaseDate { get; private set; }
        //public object Genre { get; private set; }


        // GET: api/<Songs>
        [HttpGet]
        public IActionResult GetAllSongs()
        {
            try
            {
                var songs = _context.Songs.ToList();
                if (songs == null )
                {
                    return NotFound();
                }
                return Ok(songs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        // GET api/<Songs>/5
        [HttpGet("{id}")]
        public IActionResult GetSongsById(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            return Ok(song);
        }

        // POST api/<Songs>
        [HttpPost]
        public IActionResult  CreateSong([FromBody] Song newSong)
        {
            if (newSong == null)
            {
                return BadRequest("Invalid data");
            }
            try
            {
                _context.Songs.Add(newSong);
                _context.SaveChanges();

                return StatusCode(201,newSong);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        // PUT api/<Songs>/5
        [HttpPut("{id}")]
        public IActionResult UpdateSong(int id, [FromBody] Song updatedSong)
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

            _context.SaveChanges();
            return Ok(song);
        }

        // DELETE api/<Songs>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSong(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            {
                return NotFound();
            }
            _context.Songs.Remove(song);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
