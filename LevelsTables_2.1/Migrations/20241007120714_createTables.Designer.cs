﻿// <auto-generated />
using System;
using LevelsTables.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LevelsTables_2._1.Migrations
{
    [DbContext(typeof(LevelsDbContext))]
    [Migration("20241007120714_createTables")]
    partial class createTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlisonicLevels.Models.Calibration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Level");

                    b.Property<int>("TankId");

                    b.Property<decimal>("Volume");

                    b.Property<decimal?>("modificator");

                    b.Property<decimal>("ratio");

                    b.Property<long>("timeOfUploadOrUpdate");

                    b.HasKey("Id");

                    b.HasIndex("TankId");

                    b.ToTable("Calibrations");
                });

            modelBuilder.Entity("Levels.Models.Tank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Address")
                        .HasMaxLength(20);

                    b.Property<decimal?>("Alert_Level");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("ExternalProbeId")
                        .HasMaxLength(50);

                    b.Property<int?>("FuelID");

                    b.Property<decimal?>("MaxVolume");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ProbeSerial")
                        .HasMaxLength(20);

                    b.Property<int?>("Probetype");

                    b.Property<decimal?>("Product_zero");

                    b.Property<int?>("StationID");

                    b.Property<int>("TankNumber");

                    b.Property<string>("TankUID")
                        .HasMaxLength(20);

                    b.Property<decimal?>("Water_zero");

                    b.HasKey("Id");

                    b.ToTable("Tanks");

                    b.HasData(
                        new { Id = 1, Active = true, Address = "Вулиця 1", Alert_Level = 75000m, Description = "Основний резервуар для зберігання продуктів 1", ExternalProbeId = "PROB001", FuelID = 1, MaxVolume = 500000m, Name = "Резервуар 1", ProbeSerial = "PR001", Probetype = 0, Product_zero = 20000m, StationID = 101, TankNumber = 1, TankUID = "T001", Water_zero = 15000m },
                        new { Id = 2, Active = false, Address = "Вулиця 2", Alert_Level = 60000m, Description = "Допоміжний резервуар для зберігання продуктів Б", ExternalProbeId = "PROB002", FuelID = 2, MaxVolume = 300000m, Name = "Резервуар 2", ProbeSerial = "PR002", Probetype = 1, Product_zero = 15000m, StationID = 102, TankNumber = 2, TankUID = "T002", Water_zero = 10000m },
                        new { Id = 3, Active = true, Address = "Вулиця 3", Alert_Level = 80000m, Description = "Експериментальний резервуар для тестування нових продуктів", ExternalProbeId = "PROB003", FuelID = 3, MaxVolume = 400000m, Name = "Резервуар 3", ProbeSerial = "PR003", Probetype = 2, Product_zero = 25000m, StationID = 103, TankNumber = 3, TankUID = "T003", Water_zero = 18000m }
                    );
                });

            modelBuilder.Entity("AlisonicLevels.Models.Calibration", b =>
                {
                    b.HasOne("Levels.Models.Tank", "Tank")
                        .WithMany("Calibrations")
                        .HasForeignKey("TankId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
