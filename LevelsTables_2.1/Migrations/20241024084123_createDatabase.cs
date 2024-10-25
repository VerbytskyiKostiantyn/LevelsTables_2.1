using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LevelsTables_2._1.Migrations
{
    public partial class createDatabase : Migration
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
                name: "Tanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 20, nullable: true),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    MaxVolume = table.Column<decimal>(nullable: true),
                    Product_zero = table.Column<decimal>(nullable: true),
                    Water_zero = table.Column<decimal>(nullable: true),
                    Alert_Level = table.Column<decimal>(nullable: true),
                    FuelID = table.Column<int>(nullable: true),
                    StationID = table.Column<int>(nullable: true),
                    TankNumber = table.Column<int>(nullable: false),
                    TankUID = table.Column<string>(maxLength: 20, nullable: true),
                    ProbeSerial = table.Column<string>(maxLength: 20, nullable: true),
                    Probetype = table.Column<int>(nullable: true),
                    ExternalProbeId = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.Id);
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
                    DateOfLastUpdate = table.Column<long>(nullable: false),
                    DateOfLastIn = table.Column<long>(nullable: false)
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
                    DateOfLastUpdate = table.Column<long>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Calibrations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TankId = table.Column<int>(nullable: false),
                    Level = table.Column<decimal>(nullable: false),
                    Volume = table.Column<decimal>(nullable: false),
                    modificator = table.Column<decimal>(nullable: true),
                    ratio = table.Column<decimal>(nullable: false),
                    timeOfUploadOrUpdate = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calibrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calibrations_Tanks_TankId",
                        column: x => x.TankId,
                        principalTable: "Tanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Station 123" },
                    { 2, "Station 212" },
                    { 3, "Station 354" },
                    { 4, "Station 421" },
                    { 5, "Station 554" }
                });

            migrationBuilder.InsertData(
                table: "Tanks",
                columns: new[] { "Id", "Active", "Address", "Alert_Level", "Description", "ExternalProbeId", "FuelID", "MaxVolume", "Name", "ProbeSerial", "Probetype", "Product_zero", "StationID", "TankNumber", "TankUID", "Water_zero" },
                values: new object[,]
                {
                    { 1, true, "Вулиця 1", 75000m, "Основний резервуар для зберігання продуктів 1", "PROB001", 1, 500000m, "Резервуар 1", "PR001", 0, 20000m, 101, 1, "T001", 15000m },
                    { 2, false, "Вулиця 2", 60000m, "Допоміжний резервуар для зберігання продуктів Б", "PROB002", 2, 300000m, "Резервуар 2", "PR002", 1, 15000m, 102, 2, "T002", 10000m },
                    { 3, true, "Вулиця 3", 80000m, "Експериментальний резервуар для тестування нових продуктів", "PROB003", 3, 400000m, "Резервуар 3", "PR003", 2, 25000m, 103, 3, "T003", 18000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calibrations_TankId",
                table: "Calibrations",
                column: "TankId");

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
                name: "Calibrations");

            migrationBuilder.DropTable(
                name: "Kassas");

            migrationBuilder.DropTable(
                name: "TankForStations");

            migrationBuilder.DropTable(
                name: "Tanks");

            migrationBuilder.DropTable(
                name: "Stations");
        }
    }
}
