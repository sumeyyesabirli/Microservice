using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasgemMicroservice.Services.Cargo.DataAccesLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoStates",
                columns: table => new
                {
                    CargoStateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargoStateID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoStates", x => x.CargoStateID);
                    table.ForeignKey(
                        name: "FK_CargoStates_CargoStates_CargoStateID1",
                        column: x => x.CargoStateID1,
                        principalTable: "CargoStates",
                        principalColumn: "CargoStateID");
                });

            migrationBuilder.CreateTable(
                name: "CargoDetailes",
                columns: table => new
                {
                    CargoDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    CargoStateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoDetailes", x => x.CargoDetailID);
                    table.ForeignKey(
                        name: "FK_CargoDetailes_CargoStates_CargoStateID",
                        column: x => x.CargoStateID,
                        principalTable: "CargoStates",
                        principalColumn: "CargoStateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoDetailes_CargoStateID",
                table: "CargoDetailes",
                column: "CargoStateID");

            migrationBuilder.CreateIndex(
                name: "IX_CargoStates_CargoStateID1",
                table: "CargoStates",
                column: "CargoStateID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoDetailes");

            migrationBuilder.DropTable(
                name: "CargoStates");
        }
    }
}
