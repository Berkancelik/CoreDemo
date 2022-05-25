using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class fixedmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogRaytingID",
                table: "BlogRaytings",
                newName: "BlogRaytingId");

            migrationBuilder.RenameColumn(
                name: "AboutId",
                table: "Abouts",
                newName: "AboutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogRaytingId",
                table: "BlogRaytings",
                newName: "BlogRaytingID");

            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "Abouts",
                newName: "AboutId");
        }
    }
}
