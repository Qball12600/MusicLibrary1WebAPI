using Microsoft.EntityFrameworkCore;
using MusicLibraryWebAPI.Models;

namespace MusicLibraryWebAPI.Data
{
 
    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext() 
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }//constructor
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Modernday Cowboy",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986,1,1),
                    Genre = "Rock"
                }
           );
        
        }
        
        
    }
    
    
}
