using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Websjop.Migrations
{
    /// <inheritdoc />
    public partial class TableNameAndSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryProduct_Category_CategoriesId",
                table: "CategoryProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryProduct_Products_ProductsId",
                table: "CategoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Catergory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catergory",
                table: "Catergory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Catergory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Crafts" },
                    { 2, "Anime" }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 34, 47, 869, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 34, 47, 869, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 34, 47, 869, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryProduct_Catergory_CategoriesId",
                table: "CategoryProduct",
                column: "CategoriesId",
                principalTable: "Catergory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryProduct_Product_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryProduct_Catergory_CategoriesId",
                table: "CategoryProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryProduct_Product_ProductsId",
                table: "CategoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catergory",
                table: "Catergory");

            migrationBuilder.DeleteData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catergory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Catergory",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 7, 34, 982, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 7, 34, 982, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 7, 34, 982, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryProduct_Category_CategoriesId",
                table: "CategoryProduct",
                column: "CategoriesId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryProduct_Products_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
