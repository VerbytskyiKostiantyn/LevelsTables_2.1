using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LevelsTables_2._1.Migrations
{
    public partial class updateKassasSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Data", "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { 32000L, new DateTime(2024, 10, 12, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Kassas",
                columns: new[] { "Id", "ContainWhat", "Data", "DateOfLastIn", "DateOfLastUpdate", "StationId" },
                values: new object[] { 11, "Diesel", 10000L, new DateTime(2024, 10, 12, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 736, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "TankForStations",
                columns: new[] { "Id", "ContainWhat", "Data", "DateOfLastUpdate", "StationId" },
                values: new object[,]
                {
                    { 16, "Gas", 10000L, new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), 1 },
                    { 17, "Diesel", 10000L, new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Data", "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { 22000L, new DateTime(2024, 10, 12, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local), new DateTime(2024, 10, 14, 16, 22, 17, 781, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 779, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 22, 17, 781, DateTimeKind.Local));
        }
    }
}
