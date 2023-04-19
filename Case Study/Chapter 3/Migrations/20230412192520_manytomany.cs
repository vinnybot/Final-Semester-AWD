using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chapter3.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerProduct",
                columns: table => new
                {
                    CustomersCustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProduct", x => new { x.CustomersCustomerId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Customer_CustomersCustomerId",
                        column: x => x.CustomersCustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2023, 4, 12, 14, 25, 19, 978, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 12, 14, 25, 19, 978, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 12, 14, 25, 19, 978, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 12, 14, 25, 19, 978, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 12, 14, 25, 19, 978, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 12, 14, 25, 19, 978, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 12, 14, 25, 19, 978, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 12, 14, 25, 19, 978, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProduct_ProductsProductId",
                table: "CustomerProduct",
                column: "ProductsProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerProduct");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2023, 3, 30, 14, 41, 34, 672, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 30, 14, 41, 34, 672, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 30, 14, 41, 34, 672, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 30, 14, 41, 34, 672, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 30, 14, 41, 34, 672, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 30, 14, 41, 34, 672, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 30, 14, 41, 34, 672, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 30, 14, 41, 34, 672, DateTimeKind.Local).AddTicks(4460));
        }
    }
}
