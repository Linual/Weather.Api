using Microsoft.EntityFrameworkCore.Migrations;

namespace Weather.Api.Migrations
{
    public partial class newColumnInModel6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Coord",
                newName: "CoordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoordId",
                table: "Coord",
                newName: "Id");
        }
    }
}
