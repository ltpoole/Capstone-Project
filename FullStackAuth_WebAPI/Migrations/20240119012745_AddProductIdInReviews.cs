using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullStackAuth_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProductIdInReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96cb0036-6a5c-4028-982e-373e664b8de1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de4775a9-8c53-4fc6-8525-ed2335f220a2");

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Reviews",
                type: "longtext",
                nullable: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6fe7cb3e-d5bf-4591-a204-06ef8b639696", null, "Admin", "ADMIN" },
                    { "a113c3a3-173d-42f1-a8b5-130a772ea36f", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fe7cb3e-d5bf-4591-a204-06ef8b639696");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a113c3a3-173d-42f1-a8b5-130a772ea36f");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96cb0036-6a5c-4028-982e-373e664b8de1", null, "User", "USER" },
                    { "de4775a9-8c53-4fc6-8525-ed2335f220a2", null, "Admin", "ADMIN" }
                });
        }
    }
}
