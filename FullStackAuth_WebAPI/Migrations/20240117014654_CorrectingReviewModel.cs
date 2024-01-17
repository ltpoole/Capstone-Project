using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CorrectingReviewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423824d3-3ee7-4505-aef2-98ce2e34740e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5196a9d7-0179-4a83-a9c8-de5ea52fdfee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f40d8fb-d240-4446-a7c8-1b7cc594b463", null, "User", "USER" },
                    { "a067ea1c-81d5-40d2-9b9a-2db672289597", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f40d8fb-d240-4446-a7c8-1b7cc594b463");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a067ea1c-81d5-40d2-9b9a-2db672289597");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "423824d3-3ee7-4505-aef2-98ce2e34740e", null, "Admin", "ADMIN" },
                    { "5196a9d7-0179-4a83-a9c8-de5ea52fdfee", null, "User", "USER" }
                });
        }
    }
}
