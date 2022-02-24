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
              },
              new FormResponse
              {
                  Title = "Team of Rivals",
                  CategoryID = 2,
                  ClassificationID = 2,
                  Publisher = "Simon & Schuster",
                  Author = "Doris Kearns Goodwin",
                  ISBN = "978-0743270755",
                  NumPage = 944,
                  Price = 14.58,
              },
              new FormResponse
              {
                  Title = "The Snowball",
                  CategoryID = 2,
                  ClassificationID = 2,
                  Publisher = "Bantam",
                  Author = "Alice Schroeder",
                  ISBN = "978-0553384611",
                  NumPage = 832,
                  Price = 21.54,
              },
              new FormResponse
              {
                  Title = "American Ulysses",
                  CategoryID = 2,
                  ClassificationID = 2,
                  Publisher = "Random House",
                  Author = "Ronald C. White",
                  ISBN = "978-0812981254",
                  NumPage = 864,
                  Price = 11.61,
              },
                 new FormResponse
              {
                  Title = "Unbroken",
                  CategoryID = 3,
                  ClassificationID = 2,
                  Publisher = "Random House",
                  Author = "Laura Hillenbrand",
                  ISBN = "978-0812974492",
                  NumPage = 528,
                  Price = 13.33,
              },new FormResponse
               {
                  Title = "The Great Train Robbery",
                  CategoryID = 3,
                  ClassificationID = 1,
                  Publisher = "Vintage",
                  Author = "Michael Crichton",
                  ISBN = "978-0804171281",
                  NumPage = 288,
                  Price = 13.33,
               }, 
            
                new FormResponse
                {
                    Title = "Deep Work",
                    CategoryID = 4,
                    ClassificationID = 1,
                    Publisher = "Grand Central Publishing",
                    Author = "Cal Newport",
                    ISBN = "978-1455586691",
                    NumPage = 304,
                    Price = 14.99,
                },
              new FormResponse
              {
                  Title = "It's Your Ship",
                  CategoryID = 4,
                  ClassificationID = 2,
                  Publisher = "Grand Central Publishing",
                  Author = "Michael Abrashoff",
                  ISBN = "978-1455523023",
                  NumPage = 240,
                  Price = 21.66,
              },
                new FormResponse
                  {
                      Title = "The Virgin Way",
                      CategoryID = 5,
                      ClassificationID = 2,
                      Publisher = "Portfolio",
                      Author = "Richard Branson",
                      ISBN = "978-1591847984",
                      NumPage = 400,
                      Price = 29.16,
                  }, new FormResponse
                {
                    Title = "Sycamore Row",
                    CategoryID = 6,
                    ClassificationID = 1,
                    Publisher = "Batnam",
                    Author = "John Grisham",
                    ISBN = "978-0553393613",
                    NumPage = 642,
                    Price = 15.03,
                },
                 
                    new FormResponse
                    {
                        Title = "The Way I Heard It",
                        CategoryID = 3,
                        ClassificationID = 1,
                        Publisher = "Gallery Books",
                        Author = "Mike Rowe",
                        ISBN = "978-1982131470",
                        NumPage = 272,
                        Price = 12.3,
                    },
                      new FormResponse
                      {
                          Title = "The Complete Personal Memoirs of Ulysses S. Grant",
                          CategoryID = 2,
                          ClassificationID = 2,
                          Publisher = "CreateSpace Independent Publishing Platform",
                          Author = "Ulysses S. Grant",
                          ISBN = "978-1481216043",
                          NumPage = 552,
                          Price = 19.99,
                      },
                      new FormResponse
                      {
                          Title = "The Screwtape Letters",
                          CategoryID = 7,
                          ClassificationID = 1,
                          Publisher = "HarperOne",
                          Author = "C.S. Lewis",
                          ISBN = "978-0060652937",
                          NumPage = 209,
                          Price = 10.27,
                      },
                      new FormResponse
                      {
                          Title = "Sleep Smarter",
                          CategoryID = 8,
                          ClassificationID = 2,
                          Publisher = "Rodale Books",
                          Author = "Shawn Stevenson",
                          ISBN = "978-1623367398",
                          NumPage = 288,
                          Price = 17.59,
                      },
                      new FormResponse
                      {
                          Title = "Titan",
                          CategoryID = 2,
                          ClassificationID = 2,
                          Publisher = "Vintage",
                          Author = "Ron Chernow",
                          ISBN = "978-1400077304",
                          NumPage = 832,
                          Price = 16.59,
                      },
                      new FormResponse
                      {
                          Title = "The Hunt for Red October",
                          CategoryID = 9,
                          ClassificationID = 2,
                          Publisher = "Berkley",
                          Author = "Tom Clancy",
                          ISBN = "978-0440001027",
                          NumPage = 656,
                          Price = 9.99,
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