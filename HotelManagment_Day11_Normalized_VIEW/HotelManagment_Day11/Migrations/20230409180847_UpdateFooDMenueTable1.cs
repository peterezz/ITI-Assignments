using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFooDMenueTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReserverReserver_Service");

            migrationBuilder.AddColumn<int>(
                name: "Reserver_ServiceReserverID",
                table: "Reservers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reserver_ServiceServiceID",
                table: "Reservers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reservers",
                columns: new[] { "Reserver_ServiceReserverID", "Reserver_ServiceServiceID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_Reservers_Services_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reservers",
                columns: new[] { "Reserver_ServiceReserverID", "Reserver_ServiceServiceID" },
                principalTable: "Reservers_Services",
                principalColumns: new[] { "ReserverID", "ServiceID" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_Reservers_Services_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reservers");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reservers");

            migrationBuilder.DropColumn(
                name: "Reserver_ServiceReserverID",
                table: "Reservers");

            migrationBuilder.DropColumn(
                name: "Reserver_ServiceServiceID",
                table: "Reservers");

            migrationBuilder.CreateTable(
                name: "ReserverReserver_Service",
                columns: table => new
                {
                    ReserversId = table.Column<int>(type: "int", nullable: false),
                    servicesReserverID = table.Column<int>(type: "int", nullable: false),
                    servicesServiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserverReserver_Service", x => new { x.ReserversId, x.servicesReserverID, x.servicesServiceID });
                    table.ForeignKey(
                        name: "FK_ReserverReserver_Service_Reservers_ReserversId",
                        column: x => x.ReserversId,
                        principalTable: "Reservers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReserverReserver_Service_Reservers_Services_servicesReserverID_servicesServiceID",
                        columns: x => new { x.servicesReserverID, x.servicesServiceID },
                        principalTable: "Reservers_Services",
                        principalColumns: new[] { "ReserverID", "ServiceID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReserverReserver_Service_servicesReserverID_servicesServiceID",
                table: "ReserverReserver_Service",
                columns: new[] { "servicesReserverID", "servicesServiceID" });
        }
    }
}
