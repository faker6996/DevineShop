using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class AddWidthPropertyOfMeia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "ImageIdentityWidth",
                table: "Medias",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageIdentityWidth",
                table: "Medias");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 83, DateTimeKind.Local).AddTicks(2510), new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9224), new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9231), new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9233), new DateTime(2022, 8, 3, 9, 19, 21, 84, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8295), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8309), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8313), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8315), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8412), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8415), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8432), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8434), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8436), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8439), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8453), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8456), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8458), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 8, 3, 9, 19, 21, 85, DateTimeKind.Local).AddTicks(8461) });
        }
    }
}
