using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFooDMenueTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserver_Menus");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.CreateTable(
                name: "Reservers_Services",
                columns: table => new
                {
                    ReserverID = table.Column<int>(type: "int", nullable: false),
                    ServiceID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservers_Services", x => new { x.ReserverID, x.ServiceID });
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "price", "service" },
                values: new object[,]
                {
                    { 1, 7, "break_fast" },
                    { 2, 15, "lunch" },
                    { 3, 15, "dinner" },
                    { 4, 20, "cleaning" },
                    { 5, 14, "towel" },
                    { 6, 30, "Sweetest Surprise" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserver_ServiceService_Reserver_ServiceReserverID_Reserver_ServiceServiceID",
                table: "Reserver_ServiceService",
                columns: new[] { "Reserver_ServiceReserverID", "Reserver_ServiceServiceID" });

            migrationBuilder.CreateIndex(
                name: "IX_ReserverReserver_Service_servicesReserverID_servicesServiceID",
                table: "ReserverReserver_Service",
                columns: new[] { "servicesReserverID", "servicesServiceID" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserver_ServiceService");

            migrationBuilder.DropTable(
                name: "ReserverReserver_Service");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Reservers_Services");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<int>(type: "int", nullable: false),
                    service = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reserver_Menus",
                columns: table => new
                {
                    reserverId = table.Column<int>(type: "int", nullable: false),
                    menuId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserver_Menus", x => new { x.reserverId, x.menuId });
                    table.ForeignKey(
                        name: "FK_Reserver_Menus_Menus_menuId",
                        column: x => x.menuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserver_Menus_Reservers_reserverId",
                        column: x => x.reserverId,
                        principalTable: "Reservers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "price", "service" },
                values: new object[,]
                {
                    { 1, 7, "break_fast" },
                    { 2, 15, "lunch" },
                    { 3, 15, "dinner" },
                    { 4, 20, "cleaning" },
                    { 5, 14, "towel" },
                    { 6, 30, "s_surprise" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserver_Menus_menuId",
                table: "Reserver_Menus",
                column: "menuId");
        }
    }
}
