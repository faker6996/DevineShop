using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class AddIdInAuditable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ImageIdentityWidth",
                table: "Medias",
                type: "integer",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ImageIdentityWidth",
                table: "Medias",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

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
    }
}
