using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class Gender_AND_State_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_ReserverState_state_id",
                table: "Reservers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_ResrverGender_gender_id",
                table: "Reservers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResrverGender",
                table: "ResrverGender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReserverState",
                table: "ReserverState");

            migrationBuilder.RenameTable(
                name: "ResrverGender",
                newName: "ResrverGenders");

            migrationBuilder.RenameTable(
                name: "ReserverState",
                newName: "ReserverStates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResrverGenders",
                table: "ResrverGenders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReserverStates",
                table: "ReserverStates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_ReserverStates_state_id",
                table: "Reservers",
                column: "state_id",
                principalTable: "ReserverStates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_ResrverGenders_gender_id",
                table: "Reservers",
                column: "gender_id",
                principalTable: "ResrverGenders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_ReserverStates_state_id",
                table: "Reservers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_ResrverGenders_gender_id",
                table: "Reservers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResrverGenders",
                table: "ResrverGenders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReserverStates",
                table: "ReserverStates");

            migrationBuilder.RenameTable(
                name: "ResrverGenders",
                newName: "ResrverGender");

            migrationBuilder.RenameTable(
                name: "ReserverStates",
                newName: "ReserverState");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResrverGender",
                table: "ResrverGender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReserverState",
                table: "ReserverState",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_ReserverState_state_id",
                table: "Reservers",
                column: "state_id",
                principalTable: "ReserverState",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_ResrverGender_gender_id",
                table: "Reservers",
                column: "gender_id",
                principalTable: "ResrverGender",
                principalColumn: "Id");
        }
    }
}
