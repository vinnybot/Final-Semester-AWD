using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chapter3.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2023, 5, 1, 14, 6, 57, 777, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 6, 57, 777, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 6, 57, 777, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 6, 57, 777, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 6, 57, 777, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 6, 57, 777, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 6, 57, 777, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 6, 57, 777, DateTimeKind.Local).AddTicks(8411));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2023, 5, 1, 14, 4, 47, 214, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 4, 47, 214, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 4, 47, 214, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 4, 47, 214, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 4, 47, 214, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 4, 47, 214, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 4, 47, 214, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 1, 14, 4, 47, 214, DateTimeKind.Local).AddTicks(6602));
        }
    }
}
