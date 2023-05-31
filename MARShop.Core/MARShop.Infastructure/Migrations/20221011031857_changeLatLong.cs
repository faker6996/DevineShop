using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class changeLatLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 400, DateTimeKind.Local).AddTicks(1058), new DateTime(2022, 10, 11, 10, 18, 56, 401, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 401, DateTimeKind.Local).AddTicks(7634), new DateTime(2022, 10, 11, 10, 18, 56, 401, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 401, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 10, 11, 10, 18, 56, 401, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 401, DateTimeKind.Local).AddTicks(7653), new DateTime(2022, 10, 11, 10, 18, 56, 401, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7479), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7516), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7521), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7526), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7875), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7884), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7933), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7939), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7944), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7948), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7980), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7984), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7989), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7993), new DateTime(2022, 10, 11, 10, 18, 56, 403, DateTimeKind.Local).AddTicks(7995) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
