using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedImageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6036e48a-e742-4b9c-a820-dee1d59a596d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8c35cae-c2b5-4a6d-95f2-56ecdc688e96");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a07fdc4-3c38-4b40-96ad-aa39a0619294", null, "Admin", "ADMIN" },
                    { "de5e3bcf-37ee-4fee-9baf-e71138c84a56", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a07fdc4-3c38-4b40-96ad-aa39a0619294");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de5e3bcf-37ee-4fee-9baf-e71138c84a56");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6036e48a-e742-4b9c-a820-dee1d59a596d", null, "Admin", "ADMIN" },
                    { "d8c35cae-c2b5-4a6d-95f2-56ecdc688e96", null, "User", "USER" }
                });
        }
    }
}
