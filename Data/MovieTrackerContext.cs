using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieTracker.Models;

namespace MovieTracker.Data
{
    public class MovieTrackerContext : DbContext
    {
        public MovieTrackerContext(DbContextOptions<MovieTrackerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                   new Movie
                   {
                       MovieId = 1,
                       Title = "Car Chases and Explosions",
                       DateSeen = DateTime.Now.AddDays(-50),
                       Genre = "Action",
                       Rating = 6
                   },
                    new Movie
                    {
                        MovieId = 2,
                        Title = "Silly Misunderstandings",
                        DateSeen = DateTime.Now.AddDays(-25),
                        Rating = 7
                    },
                    new Movie
                    {
                        MovieId = 3,
                        Title = "Serious Discussions",
                        Genre = "Drama"
                    }
                );
        }
        public DbSet<MovieTracker.Models.Movie> Movie { get; set; } = default!;
    }
}
