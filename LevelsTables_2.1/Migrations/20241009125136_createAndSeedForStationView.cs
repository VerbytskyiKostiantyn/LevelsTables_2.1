using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LevelsTables_2._1.Migrations
{
    public partial class createAndSeedForStationView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kassas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StationId = table.Column<int>(nullable: false),
                    ContainWhat = table.Column<string>(nullable: true),
                    Data = table.Column<long>(nullable: false),
                    DateOfLastUpdate = table.Column<DateTime>(nullable: false),
                    DateOfLastIn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kassas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kassas_Stations_StationId",
                        column: x => x.StationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TankForStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StationId = table.Column<int>(nullable: false),
                    ContainWhat = table.Column<string>(nullable: true),
                    Data = table.Column<long>(nullable: false),
                    DateOfLastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TankForStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TankForStations_Stations_StationId",
                        column: x => x.StationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Station 1" },
                    { 2, "Station 2" },
                    { 3, "Station 3" },
                    { 4, "Station 4" },
                    { 5, "Station 5" }
                });

            migrationBuilder.InsertData(
                table: "Kassas",
                columns: new[] { "Id", "ContainWhat", "Data", "DateOfLastIn", "DateOfLastUpdate", "StationId" },
                values: new object[,]
                {
                    { 1, "Gas", 22000L, new DateTime(2024, 10, 7, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), 1 },
                    { 2, "Petrol", 15000L, new DateTime(2024, 10, 7, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), 1 },
                    { 9, "Petrol", 23000L, new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), 5 },
                    { 8, "Gas", 4000L, new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 9, 15, 51, 36, 187, DateTimeKind.Local), 5 },
                    { 3, "Diesel", 42000L, new DateTime(2024, 10, 7, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), 2 },
                    { 4, "Petrol", 53000L, new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 9, 15, 51, 36, 187, DateTimeKind.Local), 3 },
                    { 7, "Petrol", 24000L, new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 9, 15, 51, 36, 187, DateTimeKind.Local), 4 },
                    { 5, "Gas", 30000L, new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 9, 15, 51, 36, 187, DateTimeKind.Local), 4 },
                    { 6, "Diesel", 26000L, new DateTime(2024, 10, 8, 15, 51, 36, 187, DateTimeKind.Local), new DateTime(2024, 10, 9, 15, 51, 36, 187, DateTimeKind.Local), 4 }
                });

            migrationBuilder.InsertData(
                table: "TankForStations",
                columns: new[] { "Id", "ContainWhat", "Data", "DateOfLastUpdate", "StationId" },
                values: new object[,]
                {
                    { 13, "Gas", 4000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 5 },
                    { 12, "Diesel", 26000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 4 },
                    { 11, "Petrol", 24000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 4 },
                    { 10, "Gas", 16000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 4 },
                    { 9, "Gas", 14000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 4 },
                    { 8, "Petrol", 28000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 3 },
                    { 7, "Petrol", 25000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 3 },
                    { 6, "Gas", 18000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 2 },
                    { 5, "Diesel", 22000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 2 },
                    { 4, "Diesel", 20000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 2 },
                    { 3, "Petrol", 15000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 1 },
                    { 2, "Gas", 12000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 1 },
                    { 1, "Gas", 10000L, new DateTime(2024, 10, 8, 15, 51, 36, 185, DateTimeKind.Local), 1 },
                    { 14, "Petrol", 9000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 5 },
                    { 15, "Petrol", 14000L, new DateTime(2024, 10, 8, 15, 51, 36, 186, DateTimeKind.Local), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kassas_StationId",
                table: "Kassas",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_TankForStations_StationId",
                table: "TankForStations",
                column: "StationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kassas");

            migrationBuilder.DropTable(
                name: "TankForStations");

            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
