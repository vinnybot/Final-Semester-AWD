using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chapter_8.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Accommodation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccommodationEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activity3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripID);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripID", "Accommodation", "AccommodationEmail", "AccommodationPhone", "Activity1", "Activity2", "Activity3", "Destination", "EndDate", "StartDate" },
                values: new object[] { 1, "Holiday Inn Express", "", "", "Eat", "Sleep", "Fart", "Kenya", new DateTime(2023, 2, 27, 14, 59, 40, 496, DateTimeKind.Local).AddTicks(2707), new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
