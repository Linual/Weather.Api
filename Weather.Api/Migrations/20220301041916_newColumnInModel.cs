using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Weather.Api.Migrations
{
    public partial class newColumnInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clouds",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    all = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clouds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Coord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    lon = table.Column<double>(type: "double precision", nullable: false),
                    lat = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    temp = table.Column<double>(type: "double precision", nullable: false),
                    feels_like = table.Column<double>(type: "double precision", nullable: false),
                    temp_min = table.Column<double>(type: "double precision", nullable: false),
                    pressure = table.Column<int>(type: "integer", nullable: false),
                    humidity = table.Column<int>(type: "integer", nullable: false),
                    sea_level = table.Column<int>(type: "integer", nullable: false),
                    grnd_level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sys",
                columns: table => new
                {
                    SysId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    country = table.Column<string>(type: "text", nullable: true),
                    sunrise = table.Column<int>(type: "integer", nullable: false),
                    sunset = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys", x => x.SysId);
                });

            migrationBuilder.CreateTable(
                name: "Wind",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    speed = table.Column<double>(type: "double precision", nullable: false),
                    deg = table.Column<int>(type: "integer", nullable: false),
                    gust = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wind", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    idWeather = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoordId = table.Column<int>(type: "integer", nullable: true),
                    Base = table.Column<string>(type: "text", nullable: true),
                    Mainid = table.Column<int>(type: "integer", nullable: true),
                    Visibility = table.Column<int>(type: "integer", nullable: false),
                    Windid = table.Column<int>(type: "integer", nullable: true),
                    Cloudsid = table.Column<int>(type: "integer", nullable: true),
                    Dt = table.Column<int>(type: "integer", nullable: false),
                    SysId = table.Column<int>(type: "integer", nullable: false),
                    Timezone = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Cod = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.idWeather);
                    table.ForeignKey(
                        name: "FK_Weather_Clouds_Cloudsid",
                        column: x => x.Cloudsid,
                        principalTable: "Clouds",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weather_Coord_CoordId",
                        column: x => x.CoordId,
                        principalTable: "Coord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weather_Main_Mainid",
                        column: x => x.Mainid,
                        principalTable: "Main",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weather_Sys_SysId",
                        column: x => x.SysId,
                        principalTable: "Sys",
                        principalColumn: "SysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weather_Wind_Windid",
                        column: x => x.Windid,
                        principalTable: "Wind",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    main = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    icon = table.Column<string>(type: "text", nullable: true),
                    WeatherModelidWeather = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Weathers_Weather_WeatherModelidWeather",
                        column: x => x.WeatherModelidWeather,
                        principalTable: "Weather",
                        principalColumn: "idWeather",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weather_Cloudsid",
                table: "Weather",
                column: "Cloudsid");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_CoordId",
                table: "Weather",
                column: "CoordId");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_Mainid",
                table: "Weather",
                column: "Mainid");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_SysId",
                table: "Weather",
                column: "SysId");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_Windid",
                table: "Weather",
                column: "Windid");

            migrationBuilder.CreateIndex(
                name: "IX_Weathers_WeatherModelidWeather",
                table: "Weathers",
                column: "WeatherModelidWeather");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weathers");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "Clouds");

            migrationBuilder.DropTable(
                name: "Coord");

            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "Sys");

            migrationBuilder.DropTable(
                name: "Wind");
        }
    }
}
