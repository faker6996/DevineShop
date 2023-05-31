using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class AddLatLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LatLong",
                table: "Shops",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 622, DateTimeKind.Local).AddTicks(5792), new DateTime(2022, 9, 30, 14, 12, 54, 623, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 623, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 9, 30, 14, 12, 54, 623, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 623, DateTimeKind.Local).AddTicks(3441), new DateTime(2022, 9, 30, 14, 12, 54, 623, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 623, DateTimeKind.Local).AddTicks(3443), new DateTime(2022, 9, 30, 14, 12, 54, 623, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1382), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1390), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1417), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1419), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1501), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1504), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1519), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1521), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1523), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1525), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1538), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1541), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1543), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1545), new DateTime(2022, 9, 30, 14, 12, 54, 624, DateTimeKind.Local).AddTicks(1546) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LatLong",
                table: "Shops");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 739, DateTimeKind.Local).AddTicks(3932), new DateTime(2022, 8, 3, 14, 49, 33, 740, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 740, DateTimeKind.Local).AddTicks(2021), new DateTime(2022, 8, 3, 14, 49, 33, 740, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 740, DateTimeKind.Local).AddTicks(2028), new DateTime(2022, 8, 3, 14, 49, 33, 740, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 740, DateTimeKind.Local).AddTicks(2031), new DateTime(2022, 8, 3, 14, 49, 33, 740, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(19), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(27), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(29), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(31), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(107), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(127), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(131), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(144), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(146), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(148), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(186), new DateTime(2022, 8, 3, 14, 49, 33, 741, DateTimeKind.Local).AddTicks(187) });
        }
    }
}
