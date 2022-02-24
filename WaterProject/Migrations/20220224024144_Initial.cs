using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Classification",
                columns: table => new
                {
                    ClassificationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClassificationName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classification", x => x.ClassificationID);
                });

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
                    CategoryID = table.Column<int>(nullable: false),
                    ClassificationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormResponses", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_FormResponses_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormResponses_Classification_ClassificationID",
                        column: x => x.ClassificationID,
                        principalTable: "Classification",
                        principalColumn: "ClassificationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Classic" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Biography" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Historical" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Self-Help" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Business" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 6, "Thrillers" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 7, "Christian Books" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 8, "Health" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 9, "Action" });

            migrationBuilder.InsertData(
                table: "Classification",
                columns: new[] { "ClassificationID", "ClassificationName" },
                values: new object[] { 1, "Fiction" });

            migrationBuilder.InsertData(
                table: "Classification",
                columns: new[] { "ClassificationID", "ClassificationName" },
                values: new object[] { 2, "Non-Fiction" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0451419439", "Victor Hugo", 7, 1, 1488, 9.9499999999999993, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0804171281", "Michael Crichton", 3, 1, 288, 13.33, "Vintage", "The Great Train Robbery" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1455586691", "Cal Newport", 4, 1, 304, 14.99, "Grand Central Publishing", "Deep Work" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0553393613", "John Grisham", 6, 1, 642, 15.029999999999999, "Batnam", "Sycamore Row" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1982131470", "Mike Rowe", 3, 1, 272, 12.300000000000001, "Gallery Books", "The Way I Heard It" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0060652937", "C.S. Lewis", 7, 1, 209, 10.27, "HarperOne", "The Screwtape Letters" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0743270755", "Doris Kearns Goodwin", 2, 2, 944, 14.58, "Simon & Schuster", "Team of Rivals" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0553384611", "Alice Schroeder", 2, 2, 832, 21.539999999999999, "Bantam", "The Snowball" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0812981254", "Ronald C. White", 2, 2, 864, 11.609999999999999, "Random House", "American Ulysses" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0812974492", "Laura Hillenbrand", 3, 2, 528, 13.33, "Random House", "Unbroken" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1455523023", "Michael Abrashoff", 4, 2, 240, 21.66, "Grand Central Publishing", "It's Your Ship" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1591847984", "Richard Branson", 5, 2, 400, 29.16, "Portfolio", "The Virgin Way" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1481216043", "Ulysses S. Grant", 2, 2, 552, 19.989999999999998, "CreateSpace Independent Publishing Platform", "The Complete Personal Memoirs of Ulysses S. Grant" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1623367398", "Shawn Stevenson", 8, 2, 288, 17.59, "Rodale Books", "Sleep Smarter" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-1400077304", "Ron Chernow", 2, 2, 832, 16.59, "Vintage", "Titan" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "ISBN", "Author", "CategoryID", "ClassificationID", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { "978-0440001027", "Tom Clancy", 9, 2, 656, 9.9900000000000002, "Berkley", "The Hunt for Red October" });

            migrationBuilder.CreateIndex(
                name: "IX_FormResponses_CategoryID",
                table: "FormResponses",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FormResponses_ClassificationID",
                table: "FormResponses",
                column: "ClassificationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormResponses");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Classification");
        }
    }
}
