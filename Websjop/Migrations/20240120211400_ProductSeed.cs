using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Websjop.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Price", "Quantity", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 20, 22, 14, 0, 264, DateTimeKind.Local).AddTicks(6252), "A cute sticker pack that can be used anywhere!", "Cute Sticker Pack", 4.75m, 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 1, 20, 22, 14, 0, 264, DateTimeKind.Local).AddTicks(6296), "Ryouiki Tenkai: Fukuma Mizushi!", "Jujutsu Kaisen T-shirt", 19.99m, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 1, 20, 22, 14, 0, 264, DateTimeKind.Local).AddTicks(6299), "Perfect present for your loved one!", "Cricut Joy", 209.99m, 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
