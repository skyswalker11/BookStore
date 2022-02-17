using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This page provides seeding for the database tables
namespace BookStore.Models
{
    public class BookContext : DbContext
    {
        //Constructor
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<FormResponse> FormResponses { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(

                    new Category { CategoryID = 1, CategoryName = "Classic" },
                    new Category { CategoryID = 2, CategoryName = "Biography" },
                    new Category { CategoryID = 3, CategoryName = "Historical" },
                    new Category { CategoryID = 4, CategoryName = "Self-Help" },
                    new Category { CategoryID = 5, CategoryName = "Business" },
                    new Category { CategoryID = 6, CategoryName = "Thrillers" },
                    new Category { CategoryID = 7, CategoryName = "Historical" },
                    new Category { CategoryID = 8, CategoryName = "Christian Books" },                                       
                    new Category { CategoryID = 9, CategoryName = "Health" },
                    new Category { CategoryID = 10, CategoryName = "Action" }

                );

            //mb.Entity<FormResponse>().HasData(

              //  new FormResponse
              //  {
              //      ApplicationID = 1,
              //      CategoryID = 4,
              //      Title = "Lilo and Stitch",
              //      Year = 2002,
              //      Author = "Chris Sanders",
              //      Rating = "G",
              //      Edited = false,
              //      LentTo = "",
              //      Notes = ""
              //  },

              //  new FormResponse
              //  {
              //      ApplicationID = 2,
              //      CategoryID = 4,
              //      Title = "Mulan",
              //      Year = 1998,
              //      Author = "Tony Bancroft",
              //      Rating = "G",
              //      Edited = false,
              //      LentTo = "",
              //      Notes = ""
              //  },
              //  new FormResponse
              //  {
              //      ApplicationID = 3,
              //      CategoryID = 4,
              //      Title = "Aladdin",
              //      Year = 2002,
              //      Author = "Ron Clements",
              //      Rating = "G",
              //      Edited = false,
              //      LentTo = "",
              //      Notes = ""
              //  }
              //);
        }
    }
}