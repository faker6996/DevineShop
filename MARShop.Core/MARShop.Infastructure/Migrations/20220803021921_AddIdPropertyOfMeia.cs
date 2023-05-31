using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class AddIdPropertyOfMeia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageIdentityIdInVuforia",
                table: "Medias",
                type: "text",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageIdentityIdInVuforia",
                table: "Medias");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 148, DateTimeKind.Local).AddTicks(2726), new DateTime(2022, 7, 11, 8, 51, 28, 148, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(620), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(627), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(629), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8856), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8864), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8866), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8868), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8952), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8955), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8969), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8972), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8973), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8975), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8987), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8991), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8993), new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8994) });
        }
    }
}
