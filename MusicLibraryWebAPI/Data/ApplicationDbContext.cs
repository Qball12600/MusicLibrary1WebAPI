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
                    Title = "Ez Come Ez Go",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986,1,1),
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 2,
                    Title = "Cumin' Atcha Live",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986, 1, 1),
                    Genre = "Rock"
                }, 
                new Song
                {
                    Id = 3,
                    Title = "Gettin Better",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986, 1, 1),
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 4,
                    Title = "2 Late 4 Love",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986, 1, 1),
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 5,
                    Title = "Rock Me To The Top",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986, 1, 1),
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 6,
                    Title = "We're No Good Together",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986, 1, 1),
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 7,
                    Title = "Modern Day Cowboy",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986, 1, 1),
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 8,
                    Title = "Changes",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986, 1, 1),
                    Genre = "Rock"
                },
                new Song
                {
                    Id = 9,
                    Title = "Little Suzi",
                    Artist = "Tesla",
                    Album = "Mechanical Resonance",
                    ReleaseDate = new DateTime(1986, 1, 1),
                    Genre = "Rock"
                },
                 new Song
                 {
                     Id = 10,
                     Title = "Love Me",
                     Artist = "Tesla",
                     Album = "Mechanical Resonance",
                     ReleaseDate = new DateTime(1986, 1, 1),
                     Genre = "Rock"
                 },
                  new Song
                  {
                      Id = 11,
                      Title = "Cover Queen",
                      Artist = "Tesla",
                      Album = "Mechanical Resonance",
                      ReleaseDate = new DateTime(1986, 1, 1),
                      Genre = "Rock"
                  },
                   new Song
                   {
                       Id = 12,
                       Title = "Before My Eyes",
                       Artist = "Tesla",
                       Album = "Mechanical Resonance",
                       ReleaseDate = new DateTime(1986, 1, 1),
                       Genre = "Rock"
                   }
                   
           );
        
        }
        
        
    }
    
    
}
