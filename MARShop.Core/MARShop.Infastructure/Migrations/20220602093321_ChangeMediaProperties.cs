using Microsoft.EntityFrameworkCore.Migrations;

namespace MARShop.Infastructure.Migrations
{
    public partial class ChangeMediaProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MediaFileUrl",
                table: "Medias",
                newName: "MediaFile");

            migrationBuilder.RenameColumn(
                name: "ImageIdentityUrl",
                table: "Medias",
                newName: "ImageIdentity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MediaFile",
                table: "Medias",
                newName: "MediaFileUrl");

            migrationBuilder.RenameColumn(
                name: "ImageIdentity",
                table: "Medias",
                newName: "ImageIdentityUrl");
        }
    }
}
