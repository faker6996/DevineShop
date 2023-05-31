using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class SeedPermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Created", "CreatedBy", "IsDelete", "Key", "LastModified", "LastModifiedBy", "ParentId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 11, 8, 51, 28, 148, DateTimeKind.Local).AddTicks(2726), null, false, "media-create", new DateTime(2022, 7, 11, 8, 51, 28, 148, DateTimeKind.Local).AddTicks(9571), null, 0, "Thêm media" },
                    { 16, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8990), null, false, "role-update", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8990), null, 0, "Sửa nhóm quyền" },
                    { 15, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8987), null, false, "role-create", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8988), null, 0, "Thêm nhóm quyền" },
                    { 14, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8975), null, false, "account-get", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8976), null, 0, "Xem tài khoản" },
                    { 13, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8973), null, false, "account-delete", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8974), null, 0, "Xóa tài khoản" },
                    { 12, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8972), null, false, "account-update", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8972), null, 0, "Sửa tài khoản" },
                    { 11, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8969), null, false, "account-create", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8970), null, 0, "Thêm tài khoản" },
                    { 10, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8955), null, false, "app-get", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8956), null, 0, "Xem thông tin ứng dụng" },
                    { 9, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8952), null, false, "app-update", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8953), null, 0, "Sửa thông tin ứng dụng" },
                    { 8, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8868), null, false, "shop-get", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8869), null, 0, "Xem cửa hàng" },
                    { 7, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8866), null, false, "shop-delete", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8867), null, 0, "Xóa cửa hàng" },
                    { 6, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8864), null, false, "shop-update", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8865), null, 0, "Sửa cửa hàng" },
                    { 5, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8856), null, false, "shop-create", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8862), null, 0, "Thêm cửa hàng" },
                    { 4, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(629), null, false, "media-get", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(630), null, 0, "Xem media" },
                    { 3, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(627), null, false, "media-delete", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(628), null, 0, "Xóa media" },
                    { 2, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(620), null, false, "media-update", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(625), null, 0, "Sửa media" },
                    { 17, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8991), null, false, "role-delete", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8992), null, 0, "Xóa nhóm quyền" },
                    { 18, new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8993), null, false, "role-get", new DateTime(2022, 7, 11, 8, 51, 28, 149, DateTimeKind.Local).AddTicks(8994), null, 0, "Xem nhóm quyền" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
