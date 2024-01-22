using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c045ba3-f840-40ae-91c8-41e6fda63a06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a651dc9-65ed-4e7e-9614-957556a15833");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f2f4cf8-03e1-4179-a8e8-732035e93476", null, "Admin", "ADMIN" },
                    { "a71df9c7-fc66-4ded-9706-be02447f19c2", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f2f4cf8-03e1-4179-a8e8-732035e93476");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a71df9c7-fc66-4ded-9706-be02447f19c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c045ba3-f840-40ae-91c8-41e6fda63a06", null, "Admin", "ADMIN" },
                    { "3a651dc9-65ed-4e7e-9614-957556a15833", null, "User", "USER" }
                });
        }
    }
}
