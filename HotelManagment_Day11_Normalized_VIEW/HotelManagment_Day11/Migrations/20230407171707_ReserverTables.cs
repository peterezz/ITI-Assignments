using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class ReserverTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReserverChoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    room_floor = table.Column<int>(type: "int", nullable: false),
                    room_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arrival_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    leaving_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    check_in = table.Column<bool>(type: "bit", nullable: false),
                    supply_status = table.Column<bool>(type: "bit", nullable: false),
                    resrver_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserverChoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReserverState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserverState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResrverGender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResrverGender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    birth_day = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gender_id = table.Column<int>(type: "int", nullable: true),
                    phone_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    number_guest = table.Column<int>(type: "int", nullable: false),
                    street_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apt_suite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state_id = table.Column<int>(type: "int", nullable: true),
                    zip_code = table.Column<string>(type: "nchar(10)", nullable: false),
                    choices_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservers_ReserverChoices_choices_id",
                        column: x => x.choices_id,
                        principalTable: "ReserverChoices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservers_ReserverState_state_id",
                        column: x => x.state_id,
                        principalTable: "ReserverState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservers_ResrverGender_gender_id",
                        column: x => x.gender_id,
                        principalTable: "ResrverGender",
                        principalColumn: "Id");
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservers");

            migrationBuilder.DropTable(
                name: "ReserverChoices");

            migrationBuilder.DropTable(
                name: "ReserverState");

            migrationBuilder.DropTable(
                name: "ResrverGender");
        }
    }
}
