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
                    new Category { CategoryID = 7, CategoryName = "Christian Books" },                                       
                    new Category { CategoryID = 8, CategoryName = "Health" },
                    new Category { CategoryID = 9, CategoryName = "Action" }
            );

            mb.Entity<Classification>().HasData(

                   new Classification { ClassificationID = 1, ClassificationName = "Fiction" },
                   new Classification { ClassificationID = 2, ClassificationName = "Non-Fiction" }

            );

            mb.Entity<FormResponse>().HasData(

              new FormResponse
              {
                  Title = "Les Miserables",
                  CategoryID = 7,
                  ClassificationID = 1,
                  Publisher = "Signet",
                  Author = "Victor Hugo",
                  ISBN = "978-0451419439",
                  NumPage = 1488,
                  Price = 9.95,                  
              }

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
            );
        }
    }
}