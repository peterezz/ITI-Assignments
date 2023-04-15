using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReserverChoicesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_ReserverChoices_choices_id",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_choices_id",
                table: "Reservers");

            migrationBuilder.AlterColumn<string>(
                name: "room_type",
                table: "ReserverChoices",
                type: "nchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "room_number",
                table: "ReserverChoices",
                type: "nchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "room_floor",
                table: "ReserverChoices",
                type: "nchar(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ReserverChoices_resrver_id",
                table: "ReserverChoices",
                column: "resrver_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReserverChoices_Reservers_resrver_id",
                table: "ReserverChoices",
                column: "resrver_id",
                principalTable: "Reservers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReserverChoices_Reservers_resrver_id",
                table: "ReserverChoices");

            migrationBuilder.DropIndex(
                name: "IX_ReserverChoices_resrver_id",
                table: "ReserverChoices");

            migrationBuilder.AlterColumn<string>(
                name: "room_type",
                table: "ReserverChoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "room_number",
                table: "ReserverChoices",
                type: "nvarchar(max)",
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

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_choices_id",
                table: "Reservers",
                column: "choices_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_ReserverChoices_choices_id",
                table: "Reservers",
                column: "choices_id",
                principalTable: "ReserverChoices",
                principalColumn: "Id");
        }
    }
}
