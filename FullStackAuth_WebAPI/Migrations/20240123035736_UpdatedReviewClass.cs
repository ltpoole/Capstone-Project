using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReviewClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "6036e48a-e742-4b9c-a820-dee1d59a596d", null, "Admin", "ADMIN" },
                    { "d8c35cae-c2b5-4a6d-95f2-56ecdc688e96", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2f2f4cf8-03e1-4179-a8e8-732035e93476", null, "Admin", "ADMIN" },
                    { "a71df9c7-fc66-4ded-9706-be02447f19c2", null, "User", "USER" }
                });
        }
    }
}
