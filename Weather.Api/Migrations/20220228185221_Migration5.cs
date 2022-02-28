using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Weather.Api.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Sys_SysId",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys",
                table: "Sys");

            migrationBuilder.AlterColumn<int>(
                name: "SysId",
                table: "Sys",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Sys",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys",
                table: "Sys",
                column: "SysId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Sys_SysId",
                table: "Weather",
                column: "SysId",
                principalTable: "Sys",
                principalColumn: "SysId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Sys_SysId",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys",
                table: "Sys");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Sys",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "SysId",
                table: "Sys",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys",
                table: "Sys",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Sys_SysId",
                table: "Weather",
                column: "SysId",
                principalTable: "Sys",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
