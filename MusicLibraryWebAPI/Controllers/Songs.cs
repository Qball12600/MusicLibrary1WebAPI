using Microsoft.AspNetCore.Mvc;
using MusicLibraryWebAPI.Data;
using MusicLibraryWebAPI.Models;
using MySqlX.XDevAPI.CRUD;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace MusicLibraryWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
  
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
                var songs = _context.Songs.ToList();
                return Ok(songs);
         
            
        }
        // GET api/<Songs>/5
        [HttpGet("{id}")]
        public IActionResult GetSongsById(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
            
                return NotFound();
            
            return Ok(song);
        }

        // POST api/<Songs>
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            if (song == null)
            {
                return BadRequest("Invalid data");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _context.Songs.Add(song);
                _context.SaveChanges();

                return StatusCode(201,song);
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
            var existingSong = _context.Songs.Find(id);
            if (existingSong == null)
            
                return NotFound();
            
            existingSong.Title = updatedSong.Title;
            existingSong.Artist = updatedSong.Artist;
            existingSong.Album = updatedSong.Album;
            existingSong.ReleaseDate = updatedSong.ReleaseDate;
            existingSong.Genre = updatedSong.Genre;

            _context.SaveChanges();
            return Ok(existingSong);
        }

        // DELETE api/<Songs>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSong(int id)
        {
            var song = _context.Songs.Find(id);
            if (song == null)
                return NotFound();
            
            _context.Songs.Remove(song);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
