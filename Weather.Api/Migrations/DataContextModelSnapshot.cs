﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Weather.Api.Data;

namespace Weather.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Weather.Api.Models.Clouds", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("all")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Clouds");
                });

            modelBuilder.Entity("Weather.Api.Models.Coord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<double>("lat")
                        .HasColumnType("double precision");

                    b.Property<double>("lon")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Coord");
                });

            modelBuilder.Entity("Weather.Api.Models.Main", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<double>("feels_like")
                        .HasColumnType("double precision");

                    b.Property<int>("grnd_level")
                        .HasColumnType("integer");

                    b.Property<int>("humidity")
                        .HasColumnType("integer");

                    b.Property<int>("pressure")
                        .HasColumnType("integer");

                    b.Property<int>("sea_level")
                        .HasColumnType("integer");

                    b.Property<double>("temp")
                        .HasColumnType("double precision");

                    b.Property<double>("temp_min")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Main");
                });

            modelBuilder.Entity("Weather.Api.Models.Sys", b =>
                {
                    b.Property<int>("SysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<int>("id")
                        .HasColumnType("integer");

                    b.Property<int>("sunrise")
                        .HasColumnType("integer");

                    b.Property<int>("sunset")
                        .HasColumnType("integer");

                    b.Property<int>("type")
                        .HasColumnType("integer");

                    b.HasKey("SysId");

                    b.ToTable("Sys");
                });

            modelBuilder.Entity("Weather.Api.Models.WeatherModel", b =>
                {
                    b.Property<int>("idWeather")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Base")
                        .HasColumnType("text");

                    b.Property<int?>("Cloudsid")
                        .HasColumnType("integer");

                    b.Property<int>("Cod")
                        .HasColumnType("integer");

                    b.Property<int>("CoordId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Dt")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int?>("Mainid")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("SysId")
                        .HasColumnType("integer");

                    b.Property<int>("Timezone")
                        .HasColumnType("integer");

                    b.Property<int>("Visibility")
                        .HasColumnType("integer");

                    b.Property<int?>("Windid")
                        .HasColumnType("integer");

                    b.HasKey("idWeather");

                    b.HasIndex("Cloudsid");

                    b.HasIndex("CoordId");

                    b.HasIndex("Mainid");

                    b.HasIndex("SysId");

                    b.HasIndex("Windid");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("Weather.Api.Models.Weathers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("WeatherModelidWeather")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("icon")
                        .HasColumnType("text");

                    b.Property<string>("main")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("WeatherModelidWeather");

                    b.ToTable("Weathers");
                });

            modelBuilder.Entity("Weather.Api.Models.Wind", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("deg")
                        .HasColumnType("integer");

                    b.Property<double>("gust")
                        .HasColumnType("double precision");

                    b.Property<double>("speed")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("Wind");
                });

            modelBuilder.Entity("Weather.Api.Models.WeatherModel", b =>
                {
                    b.HasOne("Weather.Api.Models.Clouds", "Clouds")
                        .WithMany()
                        .HasForeignKey("Cloudsid");

                    b.HasOne("Weather.Api.Models.Coord", "Coord")
                        .WithMany()
                        .HasForeignKey("CoordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weather.Api.Models.Main", "Main")
                        .WithMany()
                        .HasForeignKey("Mainid");

                    b.HasOne("Weather.Api.Models.Sys", "Sys")
                        .WithMany()
                        .HasForeignKey("SysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Weather.Api.Models.Wind", "Wind")
                        .WithMany()
                        .HasForeignKey("Windid");

                    b.Navigation("Clouds");

                    b.Navigation("Coord");

                    b.Navigation("Main");

                    b.Navigation("Sys");

                    b.Navigation("Wind");
                });

            modelBuilder.Entity("Weather.Api.Models.Weathers", b =>
                {
                    b.HasOne("Weather.Api.Models.WeatherModel", null)
                        .WithMany("Weather")
                        .HasForeignKey("WeatherModelidWeather");
                });

            modelBuilder.Entity("Weather.Api.Models.WeatherModel", b =>
                {
                    b.Navigation("Weather");
                });
#pragma warning restore 612, 618
        }
    }
}
