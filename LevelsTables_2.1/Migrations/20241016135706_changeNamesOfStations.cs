using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LevelsTables_2._1.Migrations
{
    public partial class changeNamesOfStations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 16, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 16, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 16, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 16, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 16, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 16, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 57, 6, 537, DateTimeKind.Local), new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Station 123");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Station 212");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Station 354");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Station 421");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Station 554");

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 535, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 15, 16, 57, 6, 537, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local) });

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

            migrationBuilder.UpdateData(
                table: "Kassas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateOfLastIn", "DateOfLastUpdate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 35, 29, 738, DateTimeKind.Local), new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Station 1");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Station 2");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Station 3");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Station 4");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Station 5");

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

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TankForStations",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateOfLastUpdate",
                value: new DateTime(2024, 10, 13, 16, 35, 29, 738, DateTimeKind.Local));
        }
    }
}
