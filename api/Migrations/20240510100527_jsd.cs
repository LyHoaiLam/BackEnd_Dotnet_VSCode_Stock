using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class jsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16445206-30bf-4f1f-b91a-a99e073306ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c938ee1f-1b9b-48b5-abd4-8adc4a78b0b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7579cfbe-3978-4b1e-9d5e-460c4cee9828", null, "User", "USER" },
                    { "e0e85dcd-4e01-4314-98b9-de4d703a0429", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7579cfbe-3978-4b1e-9d5e-460c4cee9828");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0e85dcd-4e01-4314-98b9-de4d703a0429");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16445206-30bf-4f1f-b91a-a99e073306ff", null, "User", "USER" },
                    { "c938ee1f-1b9b-48b5-abd4-8adc4a78b0b6", null, "Admin", "ADMIN" }
                });
        }
    }
}
