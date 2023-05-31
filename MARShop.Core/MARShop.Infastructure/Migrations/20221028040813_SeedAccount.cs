using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class SeedAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Accounts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDelete", "LastModified", "LastModifiedBy", "Password", "Role", "UserName" },
                values: new object[] { 1, new DateTime(2022, 10, 28, 11, 8, 12, 705, DateTimeKind.Local).AddTicks(1184), null, false, new DateTime(2022, 10, 28, 11, 8, 12, 705, DateTimeKind.Local).AddTicks(1189), null, "123456789", 0, "superadmin" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 703, DateTimeKind.Local).AddTicks(4014), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(1437), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(1443), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(1445), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9073), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9082), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9084), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9159), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9177), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9180), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9182), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9184), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9196), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9199), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9201), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9203), new DateTime(2022, 10, 28, 11, 8, 12, 704, DateTimeKind.Local).AddTicks(9204) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Accounts");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 818, DateTimeKind.Local).AddTicks(5421), new DateTime(2022, 10, 21, 9, 43, 14, 819, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 819, DateTimeKind.Local).AddTicks(4359), new DateTime(2022, 10, 21, 9, 43, 14, 819, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 819, DateTimeKind.Local).AddTicks(4366), new DateTime(2022, 10, 21, 9, 43, 14, 819, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 819, DateTimeKind.Local).AddTicks(4368), new DateTime(2022, 10, 21, 9, 43, 14, 819, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2120), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2128), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2130), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2133), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2208), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2211), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2225), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2227), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2229), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2243), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2246), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2248), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2250), new DateTime(2022, 10, 21, 9, 43, 14, 820, DateTimeKind.Local).AddTicks(2251) });
        }
    }
}
