using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReserverChoiceTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "room_number",
                table: "ReserverChoices",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)");

            migrationBuilder.AlterColumn<int>(
                name: "room_floor",
                table: "ReserverChoices",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "room_number",
                table: "ReserverChoices",
                type: "nchar(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "room_floor",
                table: "ReserverChoices",
                type: "nchar(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
