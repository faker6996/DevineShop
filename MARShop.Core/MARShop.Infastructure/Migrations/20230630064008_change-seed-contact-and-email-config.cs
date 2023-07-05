using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class changeseedcontactandemailconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a09db4ad-fc61-4f17-89a8-4974719ce2d0");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "dfff0861-1fd7-44ab-89b2-d440c0942103");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "04744fd5-b0e0-43cb-981d-e65c87f6c250", new DateTime(2023, 6, 30, 13, 40, 7, 726, DateTimeKind.Local).AddTicks(3683), null, false, false, new DateTime(2023, 6, 30, 13, 40, 7, 727, DateTimeKind.Local).AddTicks(290), null, null, "$2a$11$MT9kkyBugM.nUGRo024PreR/on9ePyegj3tWHlsl2NDklRqB6oe8m", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Email", "Facebook", "IsDelete", "LastModified", "Linkedin", "Zalo" },
                values: new object[] { "1b53bad1-2aaa-4ba1-afb0-18be3e8dfc57", new DateTime(2023, 6, 30, 13, 40, 7, 859, DateTimeKind.Local).AddTicks(5941), "", "", false, new DateTime(2023, 6, 30, 13, 40, 7, 859, DateTimeKind.Local).AddTicks(5959), "", "" });

            migrationBuilder.InsertData(
                table: "EmailConfigs",
                columns: new[] { "Id", "AppPassword", "Created", "Email", "IsDelete", "LastModified" },
                values: new object[] { "832910d8-bc53-4466-b0c0-afc4a83b630e", "", new DateTime(2023, 6, 30, 13, 40, 7, 859, DateTimeKind.Local).AddTicks(9415), "", false, new DateTime(2023, 6, 30, 13, 40, 7, 859, DateTimeKind.Local).AddTicks(9421) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "04744fd5-b0e0-43cb-981d-e65c87f6c250");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "1b53bad1-2aaa-4ba1-afb0-18be3e8dfc57");

            migrationBuilder.DeleteData(
                table: "EmailConfigs",
                keyColumn: "Id",
                keyValue: "832910d8-bc53-4466-b0c0-afc4a83b630e");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "a09db4ad-fc61-4f17-89a8-4974719ce2d0", new DateTime(2023, 6, 30, 12, 28, 36, 231, DateTimeKind.Local).AddTicks(566), null, false, false, new DateTime(2023, 6, 30, 12, 28, 36, 232, DateTimeKind.Local).AddTicks(2530), null, null, "$2a$11$mWcjT4Kz0Q3h9wLd4UxHYuRlUtd2ZgzwrQAynAAphMUCVgTiUx5Lm", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Email", "Facebook", "IsDelete", "LastModified", "Linkedin", "Zalo" },
                values: new object[] { "dfff0861-1fd7-44ab-89b2-d440c0942103", new DateTime(2023, 6, 30, 12, 28, 36, 362, DateTimeKind.Local).AddTicks(3527), null, "", false, new DateTime(2023, 6, 30, 12, 28, 36, 362, DateTimeKind.Local).AddTicks(3544), "", null });
        }
    }
}
