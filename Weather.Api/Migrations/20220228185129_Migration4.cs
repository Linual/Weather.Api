using Microsoft.EntityFrameworkCore.Migrations;

namespace Weather.Api.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Sys_Sysid",
                table: "Weather");

            migrationBuilder.RenameColumn(
                name: "Sysid",
                table: "Weather",
                newName: "SysId");

            migrationBuilder.RenameIndex(
                name: "IX_Weather_Sysid",
                table: "Weather",
                newName: "IX_Weather_SysId");

            migrationBuilder.AlterColumn<int>(
                name: "SysId",
                table: "Weather",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SysId",
                table: "Sys",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Sys_SysId",
                table: "Weather",
                column: "SysId",
                principalTable: "Sys",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Sys_SysId",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "SysId",
                table: "Sys");

            migrationBuilder.RenameColumn(
                name: "SysId",
                table: "Weather",
                newName: "Sysid");

            migrationBuilder.RenameIndex(
                name: "IX_Weather_SysId",
                table: "Weather",
                newName: "IX_Weather_Sysid");

            migrationBuilder.AlterColumn<int>(
                name: "Sysid",
                table: "Weather",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Sys_Sysid",
                table: "Weather",
                column: "Sysid",
                principalTable: "Sys",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
