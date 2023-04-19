using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Context
{
    internal class MovieContext : DbContext
    {
        public MovieContext()
        {

        }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<MovieGenre> MovieGenres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1ET94B3\SQLEXPRESS;Database=MovieDB;Trusted_Connection=True;Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>().HasKey(mg => new { mg.MovieId, mg.GenreId });
            modelBuilder.Entity<MovieGenre>().HasOne(mg => mg.Movie).WithMany(m => m.MovieGenres).HasForeignKey(mg => mg.MovieId);
            modelBuilder.Entity<MovieGenre>().HasOne(mg => mg.Genre).WithMany(g => g.MovieGenres).HasForeignKey(mg => mg.GenreId);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, GenreName = "Aksiyon" },
                new Genre { GenreId = 2, GenreName = "Macera" },
                new Genre { GenreId = 3, GenreName = "Fantastik" },
                new Genre { GenreId = 4, GenreName = "Bilim Kurgu" },
                new Genre { GenreId = 5, GenreName = "Suç" },
                new Genre { GenreId = 6, GenreName = "Drama" },
                new Genre { GenreId = 7, GenreName = "Komedi" },
                new Genre { GenreId = 8, GenreName = "Romantik" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Pirates of the Caribbean: The Curse of the Black Pearl", ReleaseDate = 2003 },
                new Movie { MovieId = 2, Title = "The Matrix", ReleaseDate = 1999 },
                new Movie { MovieId = 3, Title = "The Godfather", ReleaseDate = 1972 },
                new Movie { MovieId = 4, Title = "Yes Man", ReleaseDate = 2008 },
                new Movie { MovieId = 5, Title = "Deadpool", ReleaseDate = 2016 },
                new Movie { MovieId = 6, Title = "Pride & Prejudice", ReleaseDate = 2005 }
                );

            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre { MovieId = 1, GenreId = 1 },
                new MovieGenre { MovieId = 1, GenreId = 2 },
                new MovieGenre { MovieId = 1, GenreId = 3 },
                new MovieGenre { MovieId = 2, GenreId = 1 },
                new MovieGenre { MovieId = 2, GenreId = 4 },
                new MovieGenre { MovieId = 3, GenreId = 5 },
                new MovieGenre { MovieId = 3, GenreId = 6 },
                new MovieGenre { MovieId = 4, GenreId = 7 },
                new MovieGenre { MovieId = 4, GenreId = 8 },
                new MovieGenre { MovieId = 5, GenreId = 1 },
                new MovieGenre { MovieId = 5, GenreId = 7 },
                new MovieGenre { MovieId = 6, GenreId = 6 },
                new MovieGenre { MovieId = 6, GenreId = 8 }
                );
        }
    }
}
