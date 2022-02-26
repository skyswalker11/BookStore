using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormResponses",
                columns: table => new
                {
                    ISBN = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    NumPage = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Classification = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormResponses", x => x.ISBN);
                });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0451419439", "Victor Hugo", "Classic", "Fiction", 1488, 9.9499999999999993, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0743270755", "Doris Kearns Goodwin", "Biography", "Non-Fiction", 944, 14.58, "Simon & Schuster", "Team of Rivals" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0553384611", "Alice Schroeder", "Biography", "Non-Fiction", 832, 21.539999999999999, "Bantam", "The Snowball" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0812981254", "Ronald C. White", "Biography", "Non-Fiction", 864, 11.609999999999999, "Random House", "American Ulysses" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0812974492", "Laura Hillenbrand", "Historical", "Non-Fiction", 528, 13.33, "Random House", "Unbroken" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0804171281", "Michael Crichton", "Historical", "Fiction", 288, 13.33, "Vintage", "The Great Train Robbery" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1455586691", "Cal Newport", "Self-Help", "Fiction", 304, 14.99, "Grand Central Publishing", "Deep Work" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1455523023", "Michael Abrashoff", "Self-Help", "Non-Fiction", 240, 21.66, "Grand Central Publishing", "It's Your Ship" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1591847984", "Richard Branson", "Business", "Non-Fiction", 400, 29.16, "Portfolio", "The Virgin Way" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0553393613", "John Grisham", "Thrillers", "Fiction", 642, 15.029999999999999, "Batnam", "Sycamore Row" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1982131470", "Mike Rowe", "Historical", "Fiction", 272, 12.300000000000001, "Gallery Books", "The Way I Heard It" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1481216043", "Ulysses S. Grant", "Biography", "Non-Fiction", 552, 19.989999999999998, "CreateSpace Independent Publishing Platform", "The Complete Personal Memoirs of Ulysses S. Grant" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0060652937", "C.S. Lewis", "Christian Books", "Fiction", 209, 10.27, "HarperOne", "The Screwtape Letters" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1623367398", "Shawn Stevenson", "Health", "Non-Fiction", 288, 17.59, "Rodale Books", "Sleep Smarter" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1400077304", "Ron Chernow", "Biography", "Non-Fiction", 832, 16.59, "Vintage", "Titan" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "Category", "Classification", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0440001027", "Tom Clancy", "Action", "Non-Fiction", 656, 9.9900000000000002, "Berkley", "The Hunt for Red October" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormResponses");
        }
    }
}
