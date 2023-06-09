﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Context;

#nullable disable

namespace Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Movies.Context.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            GenreName = "Aksiyon"
                        },
                        new
                        {
                            GenreId = 2,
                            GenreName = "Macera"
                        },
                        new
                        {
                            GenreId = 3,
                            GenreName = "Fantastik"
                        },
                        new
                        {
                            GenreId = 4,
                            GenreName = "Bilim Kurgu"
                        },
                        new
                        {
                            GenreId = 5,
                            GenreName = "Suç"
                        },
                        new
                        {
                            GenreId = 6,
                            GenreName = "Drama"
                        },
                        new
                        {
                            GenreId = 7,
                            GenreName = "Komedi"
                        },
                        new
                        {
                            GenreId = 8,
                            GenreName = "Romantik"
                        });
                });

            modelBuilder.Entity("Movies.Context.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<int>("ReleaseDate")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ReleaseDate = 2003,
                            Title = "Pirates of the Caribbean: The Curse of the Black Pearl"
                        },
                        new
                        {
                            MovieId = 2,
                            ReleaseDate = 1999,
                            Title = "The Matrix"
                        },
                        new
                        {
                            MovieId = 3,
                            ReleaseDate = 1972,
                            Title = "The Godfather"
                        },
                        new
                        {
                            MovieId = 4,
                            ReleaseDate = 2008,
                            Title = "Yes Man"
                        },
                        new
                        {
                            MovieId = 5,
                            ReleaseDate = 2016,
                            Title = "Deadpool"
                        },
                        new
                        {
                            MovieId = 6,
                            ReleaseDate = 2005,
                            Title = "Pride & Prejudice"
                        });
                });

            modelBuilder.Entity("Movies.Context.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenres");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 3
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 4
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 5
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 6
                        },
                        new
                        {
                            MovieId = 4,
                            GenreId = 7
                        },
                        new
                        {
                            MovieId = 4,
                            GenreId = 8
                        },
                        new
                        {
                            MovieId = 5,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 5,
                            GenreId = 7
                        },
                        new
                        {
                            MovieId = 6,
                            GenreId = 6
                        },
                        new
                        {
                            MovieId = 6,
                            GenreId = 8
                        });
                });

            modelBuilder.Entity("Movies.Context.MovieGenre", b =>
                {
                    b.HasOne("Movies.Context.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movies.Context.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Movies.Context.Genre", b =>
                {
                    b.Navigation("MovieGenres");
                });

            modelBuilder.Entity("Movies.Context.Movie", b =>
                {
                    b.Navigation("MovieGenres");
                });
#pragma warning restore 612, 618
        }
    }
}
