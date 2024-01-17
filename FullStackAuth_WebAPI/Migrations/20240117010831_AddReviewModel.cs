using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fc80a80-29e0-4373-94e8-40ad6d99f46a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99d4c78e-83c5-4d04-91bf-06072f72773e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e0d4b35-9781-44cc-be69-34777430d022", null, "Admin", "ADMIN" },
                    { "cdb2f813-0385-44cd-8a05-2ac12f21b32b", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e0d4b35-9781-44cc-be69-34777430d022");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdb2f813-0385-44cd-8a05-2ac12f21b32b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fc80a80-29e0-4373-94e8-40ad6d99f46a", null, "User", "USER" },
                    { "99d4c78e-83c5-4d04-91bf-06072f72773e", null, "Admin", "ADMIN" }
                });
        }
    }
}
