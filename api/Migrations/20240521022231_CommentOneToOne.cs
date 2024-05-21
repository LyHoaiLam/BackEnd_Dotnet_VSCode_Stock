using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class CommentOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e295a22-4d9f-42a7-9960-07b72cf7c9c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f1aa2cf-0adb-4dbe-9f63-b694ffb5b74e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fb5fdf4-a7b0-49fc-9a93-ef50e7b7557c", null, "Admin", "ADMIN" },
                    { "a533e0d5-a6cf-4c5e-a6ed-d0fc241e6c04", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fb5fdf4-a7b0-49fc-9a93-ef50e7b7557c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a533e0d5-a6cf-4c5e-a6ed-d0fc241e6c04");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e295a22-4d9f-42a7-9960-07b72cf7c9c2", null, "User", "USER" },
                    { "9f1aa2cf-0adb-4dbe-9f63-b694ffb5b74e", null, "Admin", "ADMIN" }
                });
        }
    }
}
