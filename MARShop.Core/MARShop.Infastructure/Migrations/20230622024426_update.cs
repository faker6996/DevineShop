using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "0e5170bf-908a-4a0e-84e4-91237e1aeaf4");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "b6dd114a-908c-48fb-b3cd-ddf89431c55f");

            migrationBuilder.CreateTable(
                name: "Notifies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "46370d24-50fa-4902-b001-97e13de8ff7b", new DateTime(2023, 6, 22, 9, 44, 25, 344, DateTimeKind.Local).AddTicks(5074), null, false, false, new DateTime(2023, 6, 22, 9, 44, 25, 346, DateTimeKind.Local).AddTicks(3281), null, null, "$2a$11$96ow5KjQKR8yhdXBKWBovuwJu/6QlcubevthZKpxv0XWZQ7AGjuuG", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Facebook", "IsDelete", "LastModified", "Linkedin" },
                values: new object[] { "49f6b60d-7734-470a-965b-e0d87f710fd5", new DateTime(2023, 6, 22, 9, 44, 25, 658, DateTimeKind.Local).AddTicks(2845), "", false, new DateTime(2023, 6, 22, 9, 44, 25, 658, DateTimeKind.Local).AddTicks(2879), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifies");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "46370d24-50fa-4902-b001-97e13de8ff7b");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "49f6b60d-7734-470a-965b-e0d87f710fd5");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "0e5170bf-908a-4a0e-84e4-91237e1aeaf4", new DateTime(2023, 6, 20, 14, 56, 13, 873, DateTimeKind.Local).AddTicks(5151), null, false, false, new DateTime(2023, 6, 20, 14, 56, 13, 874, DateTimeKind.Local).AddTicks(4660), null, null, "$2a$11$BjCmtssgb7ToCVRvXd9gTOgZOULKV9NQBedaotkuKeZ6j7XViroE2", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Facebook", "IsDelete", "LastModified", "Linkedin" },
                values: new object[] { "b6dd114a-908c-48fb-b3cd-ddf89431c55f", new DateTime(2023, 6, 20, 14, 56, 14, 213, DateTimeKind.Local).AddTicks(3675), "", false, new DateTime(2023, 6, 20, 14, 56, 14, 213, DateTimeKind.Local).AddTicks(3712), "" });
        }
    }
}
