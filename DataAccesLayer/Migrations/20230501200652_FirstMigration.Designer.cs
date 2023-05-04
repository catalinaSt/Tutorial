﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230501200652_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccesLayer.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("latitude")
                        .HasColumnType("int");

                    b.Property<int>("longitude")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DataAccesLayer.Models.WeatherDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AverageHumidity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<decimal>("MaxTemperature")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinTemperature")
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeSpan>("SunRise")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("SunSet")
                        .HasColumnType("time");

                    b.Property<int>("WeatherStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("WeatherStatusId");

                    b.ToTable("WeatherDays");
                });

            modelBuilder.Entity("DataAccesLayer.Models.WeatherHour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("End")
                        .HasColumnType("time");

                    b.Property<int>("Humidity")
                        .HasColumnType("int");

                    b.Property<decimal>("RealisticTemperature")
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeSpan>("Start")
                        .HasColumnType("time");

                    b.Property<decimal>("Temperature")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Visibility")
                        .HasColumnType("int");

                    b.Property<int>("WeatherStatusId")
                        .HasColumnType("int");

                    b.Property<int>("WindSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("WeatherStatusId");

                    b.ToTable("WeatherHours");
                });

            modelBuilder.Entity("DataAccesLayer.Models.WeatherStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WeatherStatus");
                });

            modelBuilder.Entity("DataAccesLayer.Models.WeatherDay", b =>
                {
                    b.HasOne("DataAccesLayer.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccesLayer.Models.WeatherStatus", "WeatherStatus")
                        .WithMany()
                        .HasForeignKey("WeatherStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("WeatherStatus");
                });

            modelBuilder.Entity("DataAccesLayer.Models.WeatherHour", b =>
                {
                    b.HasOne("DataAccesLayer.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccesLayer.Models.WeatherStatus", "WeatherStatus")
                        .WithMany()
                        .HasForeignKey("WeatherStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("WeatherStatus");
                });
#pragma warning restore 612, 618
        }
    }
}