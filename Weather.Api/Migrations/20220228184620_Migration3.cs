using Microsoft.EntityFrameworkCore.Migrations;

namespace Weather.Api.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Coord_Coordid",
                table: "Weather");

            migrationBuilder.RenameColumn(
                name: "Coordid",
                table: "Weather",
                newName: "CoordId");

            migrationBuilder.RenameIndex(
                name: "IX_Weather_Coordid",
                table: "Weather",
                newName: "IX_Weather_CoordId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Coord",
                newName: "CoordId");

            migrationBuilder.AlterColumn<int>(
                name: "CoordId",
                table: "Weather",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Coord_CoordId",
                table: "Weather",
                column: "CoordId",
                principalTable: "Coord",
                principalColumn: "CoordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Coord_CoordId",
                table: "Weather");

            migrationBuilder.RenameColumn(
                name: "CoordId",
                table: "Weather",
                newName: "Coordid");

            migrationBuilder.RenameIndex(
                name: "IX_Weather_CoordId",
                table: "Weather",
                newName: "IX_Weather_Coordid");

            migrationBuilder.RenameColumn(
                name: "CoordId",
                table: "Coord",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "Coordid",
                table: "Weather",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Coord_Coordid",
                table: "Weather",
                column: "Coordid",
                principalTable: "Coord",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
