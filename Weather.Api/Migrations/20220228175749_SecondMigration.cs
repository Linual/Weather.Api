using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Weather.Api.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weathers_Weather_WeatherModelId",
                table: "Weathers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weather",
                table: "Weather");

            migrationBuilder.RenameColumn(
                name: "WeatherModelId",
                table: "Weathers",
                newName: "WeatherModelidWeather");

            migrationBuilder.RenameIndex(
                name: "IX_Weathers_WeatherModelId",
                table: "Weathers",
                newName: "IX_Weathers_WeatherModelidWeather");

            migrationBuilder.AlterColumn<int>(
                name: "idWeather",
                table: "Weather",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Weather",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weather",
                table: "Weather",
                column: "idWeather");

            migrationBuilder.AddForeignKey(
                name: "FK_Weathers_Weather_WeatherModelidWeather",
                table: "Weathers",
                column: "WeatherModelidWeather",
                principalTable: "Weather",
                principalColumn: "idWeather",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weathers_Weather_WeatherModelidWeather",
                table: "Weathers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weather",
                table: "Weather");

            migrationBuilder.RenameColumn(
                name: "WeatherModelidWeather",
                table: "Weathers",
                newName: "WeatherModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Weathers_WeatherModelidWeather",
                table: "Weathers",
                newName: "IX_Weathers_WeatherModelId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Weather",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "idWeather",
                table: "Weather",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weather",
                table: "Weather",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Weathers_Weather_WeatherModelId",
                table: "Weathers",
                column: "WeatherModelId",
                principalTable: "Weather",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
