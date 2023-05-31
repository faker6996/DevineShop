using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class AddPermissionKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Permissions",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "Permissions");
        }
    }
}
