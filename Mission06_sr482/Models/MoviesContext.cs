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

        //Seeding data entries
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Action",
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
                    Category = "Sci-Fi",
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
                    Category = "Action",
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
