using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Medias");

            migrationBuilder.RenameColumn(
                name: "length",
                table: "Medias",
                newName: "MediaFileUrl");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Medias",
                newName: "ImageIdentityUrl");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Medias",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MediaFileUrl",
                table: "Medias",
                newName: "length");

            migrationBuilder.RenameColumn(
                name: "ImageIdentityUrl",
                table: "Medias",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Medias",
                newName: "Size");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Medias",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
