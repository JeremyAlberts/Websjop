using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Websjop.Migrations
{
    /// <inheritdoc />
    public partial class ProductCategorySeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 51, 23, 977, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 51, 23, 977, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 51, 23, 977, DateTimeKind.Local).AddTicks(1814));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 49, 36, 827, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 49, 36, 827, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 49, 36, 827, DateTimeKind.Local).AddTicks(1825));
        }
    }
}
