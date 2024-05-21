using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class hoailam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fbead87-569f-4539-8309-4fedbe606257");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93aa2889-2788-4ec6-925f-ece4b3c72c30");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "273d9d16-d197-409d-8487-19f4d2bc4931", null, "User", "USER" },
                    { "a27c760e-54e3-4122-b09c-f35a7f6e2946", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "273d9d16-d197-409d-8487-19f4d2bc4931");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a27c760e-54e3-4122-b09c-f35a7f6e2946");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fbead87-569f-4539-8309-4fedbe606257", null, "User", "USER" },
                    { "93aa2889-2788-4ec6-925f-ece4b3c72c30", null, "Admin", "ADMIN" }
                });
        }
    }
}
