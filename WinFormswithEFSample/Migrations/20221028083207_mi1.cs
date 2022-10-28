using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormswithEFSample.Migrations
{
    public partial class mi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Cheese" },
                    { 2, "Meat" },
                    { 3, "Fish" },
                    { 4, "Bread" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Cheddar" },
                    { 2, 1, "Brie" },
                    { 3, 1, "Stilton" },
                    { 4, 1, "Cheshire" },
                    { 5, 1, "Swiss" },
                    { 6, 1, "Gruyere" },
                    { 7, 1, "Colby" },
                    { 8, 1, "Mozzela" },
                    { 9, 1, "Ricotta" },
                    { 10, 1, "Parmesan" },
                    { 11, 2, "Ham" },
                    { 12, 2, "Beef" },
                    { 13, 2, "Chicken" },
                    { 14, 2, "Turkey" },
                    { 15, 2, "Prosciutto" },
                    { 16, 2, "Bacon" },
                    { 17, 2, "Mutton" },
                    { 18, 2, "Pastrami" },
                    { 19, 2, "Hazlet" },
                    { 20, 2, "Salami" },
                    { 21, 3, "Salmon" },
                    { 22, 3, "Tuna" },
                    { 23, 3, "Mackerel" },
                    { 24, 4, "Rye" },
                    { 25, 4, "Wheat" },
                    { 26, 4, "Brioche" },
                    { 27, 4, "Naan" },
                    { 28, 4, "Focaccia" },
                    { 29, 4, "Malted" },
                    { 30, 4, "Sourdough" },
                    { 31, 4, "Corn" },
                    { 32, 4, "White" },
                    { 33, 4, "Soda" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
