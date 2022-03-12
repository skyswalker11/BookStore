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
        //public DbSet<Category> Categories { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
        
        //public DbSet<Classification> Classifications { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            //mb.Entity<Category>().HasData(

            //        new Category { CategoryID = 1, CategoryName = "Classic" },
            //        new Category { Category = "Biography", CategoryName = "Biography" },
            //        new Category { Category = "Historical", CategoryName = "Historical" },
            //        new Category { Category = "Self-Help", CategoryName = "Self-Help" },
            //        new Category { Category = "Business", CategoryName = "Business" },
            //        new Category { Category = "Thrillers", CategoryName = "Thrillers" },
            //        new Category { Category = "Christian Books", CategoryName = "Christian Books" },                                       
            //        new Category { Category = "Health", CategoryName = "Health" },
            //        new Category { Category = "Action", CategoryName = "Action" }
            //);

            //mb.Entity<Classification>().HasData(

            //       new Classification { Classification = "Fiction", ClassificationName = "Fiction" },
            //       new Classification { Classification = "Non-Fiction", ClassificationName = "Non-Fiction" }

            //);

            mb.Entity<FormResponse>().HasData(

              new FormResponse
              {
                  BookId = 1,
                  Title = "Les Miserables",
                  Category = "Classic",
                  Classification = "Fiction",
                  Publisher = "Signet",
                  Author = "Victor Hugo",
                  ISBN = "978-0451419439",
                  NumPage = 1488,
                  Price = 9.95,                  
              },
              new FormResponse
              {
                  BookId = 2,
                  Title = "Team of Rivals",
                  Category = "Biography",
                  Classification = "Non-Fiction",
                  Publisher = "Simon & Schuster",
                  Author = "Doris Kearns Goodwin",
                  ISBN = "978-0743270755",
                  NumPage = 944,
                  Price = 14.58,
              },
              new FormResponse
              {
                  BookId = 3,
                  Title = "The Snowball",
                  Category = "Biography",
                  Classification = "Non-Fiction",
                  Publisher = "Bantam",
                  Author = "Alice Schroeder",
                  ISBN = "978-0553384611",
                  NumPage = 832,
                  Price = 21.54,
              },
              new FormResponse
              {
                  BookId = 4,
                  Title = "American Ulysses",
                  Category = "Biography",
                  Classification = "Non-Fiction",
                  Publisher = "Random House",
                  Author = "Ronald C. White",
                  ISBN = "978-0812981254",
                  NumPage = 864,
                  Price = 11.61,
              },
                 new FormResponse
              {
                  BookId = 5,
                  Title = "Unbroken",
                  Category = "Historical",
                  Classification = "Non-Fiction",
                  Publisher = "Random House",
                  Author = "Laura Hillenbrand",
                  ISBN = "978-0812974492",
                  NumPage = 528,
                  Price = 13.33,
              },new FormResponse
               {
                  BookId = 6,
                  Title = "The Great Train Robbery",
                  Category = "Historical",
                  Classification = "Fiction",
                  Publisher = "Vintage",
                  Author = "Michael Crichton",
                  ISBN = "978-0804171281",
                  NumPage = 288,
                  Price = 13.33,
               }, 
            
                new FormResponse
                {
                    BookId = 7,
                    Title = "Deep Work",
                    Category = "Self-Help",
                    Classification = "Fiction",
                    Publisher = "Grand Central Publishing",
                    Author = "Cal Newport",
                    ISBN = "978-1455586691",
                    NumPage = 304,
                    Price = 14.99,
                },
              new FormResponse
              {
                  BookId = 8,
                  Title = "It's Your Ship",
                  Category = "Self-Help",
                  Classification = "Non-Fiction",
                  Publisher = "Grand Central Publishing",
                  Author = "Michael Abrashoff",
                  ISBN = "978-1455523023",
                  NumPage = 240,
                  Price = 21.66,
              },
                new FormResponse
                {
                    BookId = 9,
                    Title = "The Virgin Way",
                    Category = "Business",
                    Classification = "Non-Fiction",
                    Publisher = "Portfolio",
                    Author = "Richard Branson",
                    ISBN = "978-1591847984",
                    NumPage = 400,
                    Price = 29.16,
                }, 
                new FormResponse
                {
                    BookId = 10,
                    Title = "Sycamore Row",
                    Category = "Thrillers",
                    Classification = "Fiction",
                    Publisher = "Batnam",
                    Author = "John Grisham",
                    ISBN = "978-0553393613",
                    NumPage = 642,
                    Price = 15.03,
                },
                 
                new FormResponse
                {
                    BookId = 11,
                    Title = "The Way I Heard It",
                    Category = "Historical",
                    Classification = "Fiction",
                    Publisher = "Gallery Books",
                    Author = "Mike Rowe",
                    ISBN = "978-1982131470",
                    NumPage = 272,
                    Price = 12.3,
                },
                new FormResponse
                {
                    BookId = 12,
                    Title = "The Complete Personal Memoirs of Ulysses S. Grant",
                    Category = "Biography",
                    Classification = "Non-Fiction",
                    Publisher = "CreateSpace Independent Publishing Platform",
                    Author = "Ulysses S. Grant",
                    ISBN = "978-1481216043",
                    NumPage = 552,
                    Price = 19.99,
                },
                new FormResponse
                {
                    BookId = 13,
                    Title = "The Screwtape Letters",
                    Category = "Christian Books",
                    Classification = "Fiction",
                    Publisher = "HarperOne",
                    Author = "C.S. Lewis",
                    ISBN = "978-0060652937",
                    NumPage = 209,
                    Price = 10.27,
                },
                new FormResponse
                {
                    BookId = 14,
                    Title = "Sleep Smarter",
                    Category = "Health",
                    Classification = "Non-Fiction",
                    Publisher = "Rodale Books",
                    Author = "Shawn Stevenson",
                    ISBN = "978-1623367398",
                    NumPage = 288,
                    Price = 17.59,
                },
                new FormResponse
                {
                    BookId = 15,
                    Title = "Titan",
                    Category = "Biography",
                    Classification = "Non-Fiction",
                    Publisher = "Vintage",
                    Author = "Ron Chernow",
                    ISBN = "978-1400077304",
                    NumPage = 832,
                    Price = 16.59,
                },
                new FormResponse
                {
                    BookId = 16,
                    Title = "The Hunt for Red October",
                    Category = "Action",
                    Classification = "Non-Fiction",
                    Publisher = "Berkley",
                    Author = "Tom Clancy",
                    ISBN = "978-0440001027",
                    NumPage = 656,
                    Price = 9.99,
                }
            //  new FormResponse
            //  {
            //      ApplicationID = 2,
            //      Category = "Self-Help",
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
            //      Category = "Self-Help",
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