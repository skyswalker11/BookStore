using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormResponses",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    table.PrimaryKey("PK_FormResponses", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    PurchaseReceived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.PurchaseId);
                });

            migrationBuilder.CreateTable(
                name: "BasketLineItem",
                columns: table => new
                {
                    LineID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FormResponseBookId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    PurchaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketLineItem", x => x.LineID);
                    table.ForeignKey(
                        name: "FK_BasketLineItem_FormResponses_FormResponseBookId",
                        column: x => x.FormResponseBookId,
                        principalTable: "FormResponses",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasketLineItem_Purchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchases",
                        principalColumn: "PurchaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 1, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488, 9.9499999999999993, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 2, "Doris Kearns Goodwin", "Biography", "Non-Fiction", "978-0743270755", 944, 14.58, "Simon & Schuster", "Team of Rivals" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 3, "Alice Schroeder", "Biography", "Non-Fiction", "978-0553384611", 832, 21.539999999999999, "Bantam", "The Snowball" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 4, "Ronald C. White", "Biography", "Non-Fiction", "978-0812981254", 864, 11.609999999999999, "Random House", "American Ulysses" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 5, "Laura Hillenbrand", "Historical", "Non-Fiction", "978-0812974492", 528, 13.33, "Random House", "Unbroken" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 6, "Michael Crichton", "Historical", "Fiction", "978-0804171281", 288, 13.33, "Vintage", "The Great Train Robbery" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 7, "Cal Newport", "Self-Help", "Fiction", "978-1455586691", 304, 14.99, "Grand Central Publishing", "Deep Work" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 8, "Michael Abrashoff", "Self-Help", "Non-Fiction", "978-1455523023", 240, 21.66, "Grand Central Publishing", "It's Your Ship" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 9, "Richard Branson", "Business", "Non-Fiction", "978-1591847984", 400, 29.16, "Portfolio", "The Virgin Way" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 10, "John Grisham", "Thrillers", "Fiction", "978-0553393613", 642, 15.029999999999999, "Batnam", "Sycamore Row" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 11, "Mike Rowe", "Historical", "Fiction", "978-1982131470", 272, 12.300000000000001, "Gallery Books", "The Way I Heard It" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 12, "Ulysses S. Grant", "Biography", "Non-Fiction", "978-1481216043", 552, 19.989999999999998, "CreateSpace Independent Publishing Platform", "The Complete Personal Memoirs of Ulysses S. Grant" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 13, "C.S. Lewis", "Christian Books", "Fiction", "978-0060652937", 209, 10.27, "HarperOne", "The Screwtape Letters" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 14, "Shawn Stevenson", "Health", "Non-Fiction", "978-1623367398", 288, 17.59, "Rodale Books", "Sleep Smarter" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 15, "Ron Chernow", "Biography", "Non-Fiction", "978-1400077304", 832, 16.59, "Vintage", "Titan" });

            migrationBuilder.InsertData(
                table: "FormResponses",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "NumPage", "Price", "Publisher", "Title" },
                values: new object[] { 16, "Tom Clancy", "Action", "Non-Fiction", "978-0440001027", 656, 9.9900000000000002, "Berkley", "The Hunt for Red October" });

            migrationBuilder.CreateIndex(
                name: "IX_BasketLineItem_FormResponseBookId",
                table: "BasketLineItem",
                column: "FormResponseBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketLineItem_PurchaseId",
                table: "BasketLineItem",
                column: "PurchaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketLineItem");

            migrationBuilder.DropTable(
                name: "FormResponses");

            migrationBuilder.DropTable(
                name: "Purchases");
        }
    }
}
