using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sr482.Models
{
    public class MoviesContext : DbContext
    {
        // Connecting to Db
        public MoviesContext (DbContextOptions<MoviesContext> options) : base (options)
        {

        }

        public DbSet<ApplicationResponse> responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seeding data entries
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action"},
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Adventure" },
                new Category { CategoryID = 4, CategoryName = "Horror" },
                new Category { CategoryID = 5, CategoryName = "Drama" },
                new Category { CategoryID = 6, CategoryName = "Romance" },
                new Category { CategoryID = 7, CategoryName = "Thriller" },
                new Category { CategoryID = 8, CategoryName = "Science Fiction" }
                );
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Pacific Rim",
                    Year = 2013,
                    Director = "Guillermo Del Toro",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""


                },

                new ApplicationResponse
                {
                    MovieID = 2,
                    CategoryID = 3,
                    Title = "Interstellar",
                    Year = 2014,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "",


                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    CategoryID = 1,
                    Title = "Black Panther",
                    Year = 2018,
                    Director = "Ryan Coogler",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "",


                }
                );
        }
    }
}
