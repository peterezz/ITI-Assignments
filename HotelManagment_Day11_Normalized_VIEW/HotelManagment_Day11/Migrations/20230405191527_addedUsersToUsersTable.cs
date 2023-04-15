using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class addedUsersToUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "user_name", "Role", "pass_word" },
                values: new object[,]
                {
                    { "_kitchen", 1, "kitchen_" },
                    { "admin", 0, "admin" },
                    { "ceaser.krit", 0, "admin123" },
                    { "kitchen", 1, "kitchen" },
                    { "nazim.amin", 0, "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_name",
                keyValue: "_kitchen");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_name",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_name",
                keyValue: "ceaser.krit");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_name",
                keyValue: "kitchen");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_name",
                keyValue: "nazim.amin");
        }
    }
}
