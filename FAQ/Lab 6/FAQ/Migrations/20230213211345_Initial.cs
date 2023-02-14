using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FAQ.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FAQs_Topics_TopicId1",
                        column: x => x.TopicId1,
                        principalTable: "Topics",
                        principalColumn: "TopicId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "gen", "General" },
                    { "hist", "History" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "Name" },
                values: new object[,]
                {
                    { "boot", "Bootstrap" },
                    { "cs", "C#" },
                    { "js", "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "Id", "Answer", "CategoryId", "Question", "TopicId1" },
                values: new object[,]
                {
                    { 1, "A general purpose object oriented language that uses a concise, Java-like syntax.", "gen", "What is C#?", null },
                    { 2, "In 2002.", "hist", "When was C# first released?", null },
                    { 3, "A general purpose scripting language that executes in a web browser.", "gen", "What is JavaScript?", null },
                    { 4, "In 1995.", "hist", "When was JavaScript first released?", null },
                    { 5, "A CSS framework for creating responsive web apps for multiple screen sizes.", "gen", "What is Bootstrap?", null },
                    { 6, "In 2011.", "hist", "When was Bootstrap first released?", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_CategoryId",
                table: "FAQs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_TopicId1",
                table: "FAQs",
                column: "TopicId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
