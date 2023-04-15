using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFooDMenueTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_Reservers_Services_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reservers");

            migrationBuilder.DropTable(
                name: "Reserver_ServiceService");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reservers");

            migrationBuilder.DropColumn(
                name: "Reserver_ServiceReserverID",
                table: "Reservers");

            migrationBuilder.DropColumn(
                name: "Reserver_ServiceServiceID",
                table: "Reservers");

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_Services_ServiceID",
                table: "Reservers_Services",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_Services_Reservers_ReserverID",
                table: "Reservers_Services",
                column: "ReserverID",
                principalTable: "Reservers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_Services_Services_ServiceID",
                table: "Reservers_Services",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_Services_Reservers_ReserverID",
                table: "Reservers_Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservers_Services_Services_ServiceID",
                table: "Reservers_Services");

            migrationBuilder.DropIndex(
                name: "IX_Reservers_Services_ServiceID",
                table: "Reservers_Services");

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

            migrationBuilder.CreateTable(
                name: "Reserver_ServiceService",
                columns: table => new
                {
                    ServicesId = table.Column<int>(type: "int", nullable: false),
                    Reserver_ServiceReserverID = table.Column<int>(type: "int", nullable: false),
                    Reserver_ServiceServiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserver_ServiceService", x => new { x.ServicesId, x.Reserver_ServiceReserverID, x.Reserver_ServiceServiceID });
                    table.ForeignKey(
                        name: "FK_Reserver_ServiceService_Reservers_Services_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                        columns: x => new { x.Reserver_ServiceReserverID, x.Reserver_ServiceServiceID },
                        principalTable: "Reservers_Services",
                        principalColumns: new[] { "ReserverID", "ServiceID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserver_ServiceService_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservers_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reservers",
                columns: new[] { "Reserver_ServiceReserverID", "Reserver_ServiceServiceID" });

            migrationBuilder.CreateIndex(
                name: "IX_Reserver_ServiceService_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reserver_ServiceService",
                columns: new[] { "Reserver_ServiceReserverID", "Reserver_ServiceServiceID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservers_Reservers_Services_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reservers",
                columns: new[] { "Reserver_ServiceReserverID", "Reserver_ServiceServiceID" },
                principalTable: "Reservers_Services",
                principalColumns: new[] { "ReserverID", "ServiceID" });
        }
    }
}
