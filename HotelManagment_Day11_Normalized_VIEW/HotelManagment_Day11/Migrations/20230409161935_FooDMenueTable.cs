using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagment_Day11.Migrations
{
    /// <inheritdoc />
    public partial class FooDMenueTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reserver_Menus");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
