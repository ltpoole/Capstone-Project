using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddIsAdminToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5981504e-1f3b-4a64-aa84-80cf9d76cdc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bffe10e7-a0cd-4b4a-b449-7232106cb1db");

            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Products",
                newName: "Quantity");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fc80a80-29e0-4373-94e8-40ad6d99f46a", null, "User", "USER" },
                    { "99d4c78e-83c5-4d04-91bf-06072f72773e", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fc80a80-29e0-4373-94e8-40ad6d99f46a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99d4c78e-83c5-4d04-91bf-06072f72773e");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Products",
                newName: "StockQuantity");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5981504e-1f3b-4a64-aa84-80cf9d76cdc1", null, "Admin", "ADMIN" },
                    { "bffe10e7-a0cd-4b4a-b449-7232106cb1db", null, "User", "USER" }
                });
        }
    }
}
