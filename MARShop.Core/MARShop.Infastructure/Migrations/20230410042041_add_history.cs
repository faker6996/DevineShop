using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MARShop.Infastructure.Migrations
{
    public partial class add_history : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    MediaId = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(9606), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(1212), new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9380), new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9386), new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9388), new DateTime(2023, 4, 10, 11, 20, 40, 905, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7333), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7341), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7443), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7445), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7447), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7449), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7468), new DateTime(2023, 4, 10, 11, 20, 40, 906, DateTimeKind.Local).AddTicks(7469) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 10, 28, 11, 8, 12, 705, DateTimeKind.Local).AddTicks(1184), new DateTime(2022, 10, 28, 11, 8, 12, 705, DateTimeKind.Local).AddTicks(1189) });

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
    }
}
