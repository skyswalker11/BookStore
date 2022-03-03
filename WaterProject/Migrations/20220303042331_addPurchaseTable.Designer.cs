﻿// <auto-generated />
using System;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStore.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20220303042331_addPurchaseTable")]
    partial class addPurchaseTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("BookStore.Models.BasketLineItem", b =>
                {
                    b.Property<int>("LineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FormResponseISBN")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PurchaseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineID");

                    b.HasIndex("FormResponseISBN");

                    b.HasIndex("PurchaseId");

                    b.ToTable("BasketLineItem");
                });

            modelBuilder.Entity("BookStore.Models.FormResponse", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumPage")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ISBN");

                    b.ToTable("FormResponses");

                    b.HasData(
                        new
                        {
                            ISBN = "978-0451419439",
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            NumPage = 1488,
                            Price = 9.9499999999999993,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            ISBN = "978-0743270755",
                            Author = "Doris Kearns Goodwin",
                            Category = "Biography",
                            Classification = "Non-Fiction",
                            NumPage = 944,
                            Price = 14.58,
                            Publisher = "Simon & Schuster",
                            Title = "Team of Rivals"
                        },
                        new
                        {
                            ISBN = "978-0553384611",
                            Author = "Alice Schroeder",
                            Category = "Biography",
                            Classification = "Non-Fiction",
                            NumPage = 832,
                            Price = 21.539999999999999,
                            Publisher = "Bantam",
                            Title = "The Snowball"
                        },
                        new
                        {
                            ISBN = "978-0812981254",
                            Author = "Ronald C. White",
                            Category = "Biography",
                            Classification = "Non-Fiction",
                            NumPage = 864,
                            Price = 11.609999999999999,
                            Publisher = "Random House",
                            Title = "American Ulysses"
                        },
                        new
                        {
                            ISBN = "978-0812974492",
                            Author = "Laura Hillenbrand",
                            Category = "Historical",
                            Classification = "Non-Fiction",
                            NumPage = 528,
                            Price = 13.33,
                            Publisher = "Random House",
                            Title = "Unbroken"
                        },
                        new
                        {
                            ISBN = "978-0804171281",
                            Author = "Michael Crichton",
                            Category = "Historical",
                            Classification = "Fiction",
                            NumPage = 288,
                            Price = 13.33,
                            Publisher = "Vintage",
                            Title = "The Great Train Robbery"
                        },
                        new
                        {
                            ISBN = "978-1455586691",
                            Author = "Cal Newport",
                            Category = "Self-Help",
                            Classification = "Fiction",
                            NumPage = 304,
                            Price = 14.99,
                            Publisher = "Grand Central Publishing",
                            Title = "Deep Work"
                        },
                        new
                        {
                            ISBN = "978-1455523023",
                            Author = "Michael Abrashoff",
                            Category = "Self-Help",
                            Classification = "Non-Fiction",
                            NumPage = 240,
                            Price = 21.66,
                            Publisher = "Grand Central Publishing",
                            Title = "It's Your Ship"
                        },
                        new
                        {
                            ISBN = "978-1591847984",
                            Author = "Richard Branson",
                            Category = "Business",
                            Classification = "Non-Fiction",
                            NumPage = 400,
                            Price = 29.16,
                            Publisher = "Portfolio",
                            Title = "The Virgin Way"
                        },
                        new
                        {
                            ISBN = "978-0553393613",
                            Author = "John Grisham",
                            Category = "Thrillers",
                            Classification = "Fiction",
                            NumPage = 642,
                            Price = 15.029999999999999,
                            Publisher = "Batnam",
                            Title = "Sycamore Row"
                        },
                        new
                        {
                            ISBN = "978-1982131470",
                            Author = "Mike Rowe",
                            Category = "Historical",
                            Classification = "Fiction",
                            NumPage = 272,
                            Price = 12.300000000000001,
                            Publisher = "Gallery Books",
                            Title = "The Way I Heard It"
                        },
                        new
                        {
                            ISBN = "978-1481216043",
                            Author = "Ulysses S. Grant",
                            Category = "Biography",
                            Classification = "Non-Fiction",
                            NumPage = 552,
                            Price = 19.989999999999998,
                            Publisher = "CreateSpace Independent Publishing Platform",
                            Title = "The Complete Personal Memoirs of Ulysses S. Grant"
                        },
                        new
                        {
                            ISBN = "978-0060652937",
                            Author = "C.S. Lewis",
                            Category = "Christian Books",
                            Classification = "Fiction",
                            NumPage = 209,
                            Price = 10.27,
                            Publisher = "HarperOne",
                            Title = "The Screwtape Letters"
                        },
                        new
                        {
                            ISBN = "978-1623367398",
                            Author = "Shawn Stevenson",
                            Category = "Health",
                            Classification = "Non-Fiction",
                            NumPage = 288,
                            Price = 17.59,
                            Publisher = "Rodale Books",
                            Title = "Sleep Smarter"
                        },
                        new
                        {
                            ISBN = "978-1400077304",
                            Author = "Ron Chernow",
                            Category = "Biography",
                            Classification = "Non-Fiction",
                            NumPage = 832,
                            Price = 16.59,
                            Publisher = "Vintage",
                            Title = "Titan"
                        },
                        new
                        {
                            ISBN = "978-0440001027",
                            Author = "Tom Clancy",
                            Category = "Action",
                            Classification = "Non-Fiction",
                            NumPage = 656,
                            Price = 9.9900000000000002,
                            Publisher = "Berkley",
                            Title = "The Hunt for Red October"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("BookStore.Models.BasketLineItem", b =>
                {
                    b.HasOne("BookStore.Models.FormResponse", "FormResponse")
                        .WithMany()
                        .HasForeignKey("FormResponseISBN");

                    b.HasOne("BookStore.Models.Purchase", null)
                        .WithMany("Line")
                        .HasForeignKey("PurchaseId");
                });
#pragma warning restore 612, 618
        }
    }
}
