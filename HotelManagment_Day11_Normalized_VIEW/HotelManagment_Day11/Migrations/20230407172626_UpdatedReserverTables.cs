using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReserverTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservers_choices_id",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_gender_id",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_state_id",
                table: "Reservers");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_choices_id",
                table: "Reservers",
                column: "choices_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_gender_id",
                table: "Reservers",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_state_id",
                table: "Reservers",
                column: "state_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservers_choices_id",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_gender_id",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_state_id",
                table: "Reservers");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_choices_id",
                table: "Reservers",
                column: "choices_id",
                unique: true,
                filter: "[choices_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_gender_id",
                table: "Reservers",
                column: "gender_id",
                unique: true,
                filter: "[gender_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_state_id",
                table: "Reservers",
                column: "state_id",
                unique: true,
                filter: "[state_id] IS NOT NULL");
        }
    }
}
