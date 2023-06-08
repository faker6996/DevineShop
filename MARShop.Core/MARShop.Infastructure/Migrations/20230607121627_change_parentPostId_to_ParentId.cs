using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class change_parentPostId_to_ParentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "cb66d301-7c39-4420-afb5-c0688fbe0009");

            migrationBuilder.RenameColumn(
                name: "ParentPostId",
                table: "Comments",
                newName: "ParentId");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "8e3fc3c1-b09f-4a26-8256-46cdf2ddd57e", new DateTime(2023, 6, 7, 19, 16, 27, 68, DateTimeKind.Local).AddTicks(6568), null, false, false, new DateTime(2023, 6, 7, 19, 16, 27, 71, DateTimeKind.Local).AddTicks(8163), null, null, "$2a$11$xfIiPpC/w96.6pHLswPd6Omy9ZH/fqeMakLV0ylg1rd8SOj1v4TbO", "Admin", "superadmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "8e3fc3c1-b09f-4a26-8256-46cdf2ddd57e");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Comments",
                newName: "ParentPostId");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "cb66d301-7c39-4420-afb5-c0688fbe0009", new DateTime(2023, 6, 7, 14, 57, 35, 973, DateTimeKind.Local).AddTicks(777), null, false, false, new DateTime(2023, 6, 7, 14, 57, 35, 974, DateTimeKind.Local).AddTicks(282), null, null, "$2a$11$fmYjoLAxwx2SFfvEK09DGuZYTy/pxFUcNd/ge3l3O5.FIbxf3DvkO", "Admin", "superadmin" });
        }
    }
}
