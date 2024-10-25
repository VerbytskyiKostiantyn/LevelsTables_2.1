using Microsoft.EntityFrameworkCore.Migrations;

namespace LevelsTables_2._1.Migrations
{
    public partial class seedKassasAndTnkForStationsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kassas",
                columns: new[] { "Id", "ContainWhat", "Data", "DateOfLastIn", "DateOfLastUpdate", "StationId" },
                values: new object[,]
                {
                    { 1, "Gas", 32000L, 1643716800L, 1643723400L, 1 },
                    { 11, "Diesel", 10000L, 1643716800L, 1643723400L, 1 },
                    { 10, "Gas", 18000L, 1643726400L, 1643730000L, 2 },
                    { 8, "Gas", 4000L, 1643726400L, 1643730000L, 5 },
                    { 7, "Petrol", 24000L, 1643726400L, 1643730000L, 4 },
                    { 9, "Petrol", 23000L, 1643716800L, 1643723400L, 5 },
                    { 5, "Gas", 30000L, 1643726400L, 1643730000L, 4 },
                    { 4, "Petrol", 53000L, 1643726400L, 1643730000L, 3 },
                    { 3, "Diesel", 42000L, 1643716800L, 1643723400L, 2 },
                    { 2, "Petrol", 15000L, 1643716800L, 1643723400L, 1 },
                    { 6, "Diesel", 26000L, 1643726400L, 1643730000L, 4 }
                });

            migrationBuilder.InsertData(
                table: "TankForStations",
                columns: new[] { "Id", "ContainWhat", "Data", "DateOfLastUpdate", "StationId" },
                values: new object[,]
                {
                    { 10, "Gas", 16000L, 1643692800L, 4 },
                    { 15, "Petrol", 14000L, 1643725800L, 5 },
                    { 14, "Petrol", 9000L, 1643712600L, 5 },
                    { 13, "Gas", 4000L, 1643703600L, 5 },
                    { 12, "Diesel", 26000L, 1643724600L, 4 },
                    { 11, "Petrol", 24000L, 1643716200L, 4 },
                    { 9, "Gas", 14000L, 1643722200L, 4 },
                    { 3, "Petrol", 15000L, 1643730000L, 1 },
                    { 7, "Petrol", 25000L, 1643696400L, 3 },
                    { 6, "Gas", 18000L, 1643720400L, 2 },
                    { 5, "Diesel", 22000L, 1643713200L, 2 },
                    { 4, "Diesel", 20000L, 1643700000L, 2 },
                    { 16, "Gas", 10000L, 1643699200L, 1 },
                    { 2, "Gas", 12000L, 1643716800L, 1 },
                    { 1, "Gas", 10000L, 1643723400L, 1 },
                    { 8, "Petrol", 28000L, 1643719800L, 3 },
                    { 17, "Diesel", 10000L, 1643719200L, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
