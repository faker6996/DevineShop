using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MARShop.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class update_efcore9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Tags",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Notifies",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Notifies",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "EmailConfigs",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "EmailConfigs",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Contacts",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Contacts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Comments",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "BlogPostTags",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BlogPostTags",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "BlogPosts",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BlogPosts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Accounts",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Accounts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AccountBlogPosts",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AccountBlogPosts",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Created", "Email", "IsDelete", "IsSendEmailWhenHaveNewPost", "LastModified", "LinkWeb", "Name", "Password", "Role", "UserName" },
                values: new object[] { "4f8f98e7-1a2c-4f2d-9494-2452e7ade802", new DateTime(2024, 12, 10, 4, 38, 17, 291, DateTimeKind.Utc).AddTicks(4147), "kieuminhduc02@gmail.com", false, false, new DateTime(2024, 12, 10, 4, 38, 17, 292, DateTimeKind.Utc).AddTicks(7759), null, null, "$2a$11$ABZD0VNMImxGBcxwRzqJROJ3Ab1JqUwEhWwgREp/nhzzHR3OWZbKW", "Admin", "superadmin" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Created", "Email", "Facebook", "IsDelete", "LastModified", "Linkedin", "Zalo" },
                values: new object[] { "73da585a-ca1f-404c-9e87-c6f81361c039", new DateTime(2024, 12, 10, 4, 38, 17, 706, DateTimeKind.Utc).AddTicks(8088), "", "", false, new DateTime(2024, 12, 10, 4, 38, 17, 706, DateTimeKind.Utc).AddTicks(8101), "", "" });

            migrationBuilder.InsertData(
                table: "EmailConfigs",
                columns: new[] { "Id", "AppPassword", "Created", "Email", "IsDelete", "LastModified" },
                values: new object[] { "232b515c-373d-4e17-86f6-a1c1aea23288", "ybri advf vvni efko", new DateTime(2024, 12, 10, 4, 38, 17, 707, DateTimeKind.Utc).AddTicks(3446), "kieuminhduc02@gmail.com", false, new DateTime(2024, 12, 10, 4, 38, 17, 707, DateTimeKind.Utc).AddTicks(3453) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "4f8f98e7-1a2c-4f2d-9494-2452e7ade802");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "73da585a-ca1f-404c-9e87-c6f81361c039");

            migrationBuilder.DeleteData(
                table: "EmailConfigs",
                keyColumn: "Id",
                keyValue: "232b515c-373d-4e17-86f6-a1c1aea23288");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Tags",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Notifies",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Notifies",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "EmailConfigs",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "EmailConfigs",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Contacts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Contacts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Comments",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Comments",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "BlogPostTags",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BlogPostTags",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "BlogPosts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "BlogPosts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "Accounts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Accounts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "AccountBlogPosts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "AccountBlogPosts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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
    }
}
