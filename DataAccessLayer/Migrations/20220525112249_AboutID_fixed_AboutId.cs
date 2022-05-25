using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AboutID_fixed_AboutId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "Abouts",
                newName: "AboutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutId",
                table: "Abouts",
                newName: "AboutID");
        }
    }
}
