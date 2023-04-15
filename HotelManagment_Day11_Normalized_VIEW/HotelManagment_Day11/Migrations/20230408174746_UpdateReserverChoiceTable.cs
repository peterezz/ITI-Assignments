using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReserverChoiceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "room_type",
                table: "ReserverChoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "room_type",
                table: "ReserverChoices",
                type: "nchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
