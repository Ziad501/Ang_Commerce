using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eStoreApi.Migrations
{
    /// <inheritdoc />
    public partial class eStoreInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "estore");

            migrationBuilder.CreateTable(
                name: "categories",
                schema: "estore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_categories_categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalSchema: "estore",
                        principalTable: "categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                schema: "estore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Ratings = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    ProductImg = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "estore",
                        principalTable: "categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "estore",
                table: "categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Men", null },
                    { 2, "Women", null },
                    { 3, "Kids", null },
                    { 4, "Casual Wear", 1 },
                    { 5, "Party Wear", 2 },
                    { 6, "Foot Wear", 2 },
                    { 7, "Accessories", 3 }
                });

            migrationBuilder.InsertData(
                schema: "estore",
                table: "products",
                columns: new[] { "Id", "CategoryId", "Price", "ProductDescription", "ProductImg", "ProductName", "Ratings" },
                values: new object[,]
                {
                    { 1, 5, 100.00m, "Jacket description goes here", "shop-1.jpg", "Jacket", 5 },
                    { 2, 7, 25.00m, "Very nice purse", "shop-2.jpg", "Purse", 3 },
                    { 3, 5, 45.00m, "Nice Party Dress", "shop-3.jpg", "Dress", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_categories_ParentCategoryId",
                schema: "estore",
                table: "categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                schema: "estore",
                table: "products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products",
                schema: "estore");

            migrationBuilder.DropTable(
                name: "categories",
                schema: "estore");
        }
    }
}
