using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Chapter3.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "TRNY10", "Tournament Master 1.0", 4.99m, "12/01/2018" },
                    { 2, "LEAG10", "League Scheduler 1.0", 4.99m, "05/01/2019" },
                    { 3, "LEAGD10", "League Scheduler Deluxe 1.0", 7.99m, "08/01/2019" },
                    { 4, "DRAFT10", "Draft Manager 1.0", 4.99m, "02/01/2020" },
                    { 5, "TEAM10", "Team Manager 1.0", 4.99m, "05/01/2020" },
                    { 6, "TRNY20", "Tournament Master 2.0", 5.99m, "02/15/2021" },
                    { 7, "DRAFT20", "Draft Manager 2.0", 5.99m, "07/15/2022" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
