using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddImageFileToProductClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02f3cc38-32a9-4a41-b29b-6ff4bc84d902");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccd95342-32c2-4ceb-951c-289b0a4d7039");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7fc3e540-5c7d-4c37-8d4f-e1d813cd320f", null, "User", "USER" },
                    { "d163e765-d947-49d7-8569-54f5a5a2f73a", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fc3e540-5c7d-4c37-8d4f-e1d813cd320f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d163e765-d947-49d7-8569-54f5a5a2f73a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02f3cc38-32a9-4a41-b29b-6ff4bc84d902", null, "Admin", "ADMIN" },
                    { "ccd95342-32c2-4ceb-951c-289b0a4d7039", null, "User", "USER" }
                });
        }
    }
}
