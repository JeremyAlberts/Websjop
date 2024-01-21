using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Websjop.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryProduct_Catergory_CategoriesId",
                table: "CategoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catergory",
                table: "Catergory");

            migrationBuilder.RenameTable(
                name: "Catergory",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 40, 29, 892, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 40, 29, 892, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 21, 21, 40, 29, 892, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryProduct_Category_CategoriesId",
                table: "CategoryProduct",
                column: "CategoriesId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryProduct_Category_CategoriesId",
                table: "CategoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Catergory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catergory",
                table: "Catergory",
                column: "Id");

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
        }
    }
}
