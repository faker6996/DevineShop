using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class addmailConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "8e3fc3c1-b09f-4a26-8256-46cdf2ddd57e");

            migrationBuilder.CreateTable(
                name: "EmailConfig",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    AppPassword = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfig", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "5c628447-61b7-47f2-ab28-e5691e2ca15d", new DateTime(2023, 6, 10, 15, 32, 38, 163, DateTimeKind.Local).AddTicks(3206), null, false, false, new DateTime(2023, 6, 10, 15, 32, 38, 164, DateTimeKind.Local).AddTicks(2430), null, null, "$2a$11$HFiM4Brhve8hcBtZE/Oacu6FMtNNyOW5hEpAevO9HOFu2AByJwtV2", "Admin", "superadmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailConfig");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "5c628447-61b7-47f2-ab28-e5691e2ca15d");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "8e3fc3c1-b09f-4a26-8256-46cdf2ddd57e", new DateTime(2023, 6, 7, 19, 16, 27, 68, DateTimeKind.Local).AddTicks(6568), null, false, false, new DateTime(2023, 6, 7, 19, 16, 27, 71, DateTimeKind.Local).AddTicks(8163), null, null, "$2a$11$xfIiPpC/w96.6pHLswPd6Omy9ZH/fqeMakLV0ylg1rd8SOj1v4TbO", "Admin", "superadmin" });
        }
    }
}
