using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class addzaloandemailincontact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "46370d24-50fa-4902-b001-97e13de8ff7b");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "49f6b60d-7734-470a-965b-e0d87f710fd5");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zalo",
                table: "Contacts",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "a09db4ad-fc61-4f17-89a8-4974719ce2d0", new DateTime(2023, 6, 30, 12, 28, 36, 231, DateTimeKind.Local).AddTicks(566), null, false, false, new DateTime(2023, 6, 30, 12, 28, 36, 232, DateTimeKind.Local).AddTicks(2530), null, null, "$2a$11$mWcjT4Kz0Q3h9wLd4UxHYuRlUtd2ZgzwrQAynAAphMUCVgTiUx5Lm", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Email", "Facebook", "IsDelete", "LastModified", "Linkedin", "Zalo" },
                values: new object[] { "dfff0861-1fd7-44ab-89b2-d440c0942103", new DateTime(2023, 6, 30, 12, 28, 36, 362, DateTimeKind.Local).AddTicks(3527), null, "", false, new DateTime(2023, 6, 30, 12, 28, 36, 362, DateTimeKind.Local).AddTicks(3544), "", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "a09db4ad-fc61-4f17-89a8-4974719ce2d0");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "dfff0861-1fd7-44ab-89b2-d440c0942103");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Zalo",
                table: "Contacts");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "46370d24-50fa-4902-b001-97e13de8ff7b", new DateTime(2023, 6, 22, 9, 44, 25, 344, DateTimeKind.Local).AddTicks(5074), null, false, false, new DateTime(2023, 6, 22, 9, 44, 25, 346, DateTimeKind.Local).AddTicks(3281), null, null, "$2a$11$96ow5KjQKR8yhdXBKWBovuwJu/6QlcubevthZKpxv0XWZQ7AGjuuG", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Facebook", "IsDelete", "LastModified", "Linkedin" },
                values: new object[] { "49f6b60d-7734-470a-965b-e0d87f710fd5", new DateTime(2023, 6, 22, 9, 44, 25, 658, DateTimeKind.Local).AddTicks(2845), "", false, new DateTime(2023, 6, 22, 9, 44, 25, 658, DateTimeKind.Local).AddTicks(2879), "" });
        }
    }
}
