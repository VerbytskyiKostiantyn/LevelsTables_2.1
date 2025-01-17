﻿using AlisonicLevels.Models;
using Levels.Models;
using LevelsTables.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
namespace LevelsTables.Models
{
    public class LevelsDbContext : DbContext
    {
        public LevelsDbContext(DbContextOptions<LevelsDbContext> options) : base(options)
        {

        }

        public DbSet<Tank> Tanks { get; set; }
        public DbSet<Calibration> Calibrations { get; set; }
        public DbSet<TankForStation> TankForStations { get; set; }
        public DbSet<Kassa> Kassas { get; set; }
        public DbSet<Station> Stations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tank>().HasData(
                new Tank
                {
                    Id = 1,
                    Name = "Резервуар 1",
                    Address = "Вулиця 1",
                    Description = "Основний резервуар для зберігання продуктів 1",
                    Active = true,
                    MaxVolume = 500000m,
                    Product_zero = 20000m,
                    Water_zero = 15000m,
                    Alert_Level = 75000m,
                    FuelID = 1,
                    StationID = 101,
                    TankNumber = 1,
                    TankUID = "T001",
                    ProbeSerial = "PR001",
                    Probetype = ProbeType.Alisonic,
                    ExternalProbeId = "PROB001"
                },
                new Tank
                {
                    Id = 2,
                    Name = "Резервуар 2",
                    Address = "Вулиця 2",
                    Description = "Допоміжний резервуар для зберігання продуктів Б",
                    Active = false,
                    MaxVolume = 300000m,
                    Product_zero = 15000m,
                    Water_zero = 10000m,
                    Alert_Level = 60000m,
                    FuelID = 2,
                    StationID = 102,
                    TankNumber = 2,
                    TankUID = "T002",
                    ProbeSerial = "PR002",
                    Probetype = ProbeType.VeederRoot,
                    ExternalProbeId = "PROB002"
                },
                new Tank
                {
                    Id = 3,
                    Name = "Резервуар 3",
                    Address = "Вулиця 3",
                    Description = "Експериментальний резервуар для тестування нових продуктів",
                    Active = true,
                    MaxVolume = 400000m,
                    Product_zero = 25000m,
                    Water_zero = 18000m,
                    Alert_Level = 80000m,
                    FuelID = 3,
                    StationID = 103,
                    TankNumber = 3,
                    TankUID = "T003",
                    ProbeSerial = "PR003",
                    Probetype = ProbeType.Sibylla,
                    ExternalProbeId = "PROB003"
                }
            );
            builder.Entity<Station>().HasData(
                new Station { Id = 1, Name = "Station 123" },
                new Station { Id = 2, Name = "Station 212" },
                new Station { Id = 3, Name = "Station 354" },
                new Station { Id = 4, Name = "Station 421" },
                new Station { Id = 5, Name = "Station 554" }
            );

            builder.Entity<TankForStation>().HasData(
                new TankForStation { Id = 1, StationId = 1, ContainWhat = "Gas", Data = 10000, DateOfLastUpdate = 1643723400 },
                new TankForStation { Id = 2, StationId = 1, ContainWhat = "Gas", Data = 12000, DateOfLastUpdate = 1643716800 },
                new TankForStation { Id = 3, StationId = 1, ContainWhat = "Petrol", Data = 15000, DateOfLastUpdate = 1643730000 },
                new TankForStation { Id = 4, StationId = 2, ContainWhat = "Diesel", Data = 20000, DateOfLastUpdate = 1643700000 },
                new TankForStation { Id = 5, StationId = 2, ContainWhat = "Diesel", Data = 22000, DateOfLastUpdate = 1643713200 },
                new TankForStation { Id = 6, StationId = 2, ContainWhat = "Gas", Data = 18000, DateOfLastUpdate = 1643720400 },
                new TankForStation { Id = 7, StationId = 3, ContainWhat = "Petrol", Data = 25000, DateOfLastUpdate = 1643696400 },
                new TankForStation { Id = 8, StationId = 3, ContainWhat = "Petrol", Data = 28000, DateOfLastUpdate = 1643719800 },
                new TankForStation { Id = 9, StationId = 4, ContainWhat = "Gas", Data = 14000, DateOfLastUpdate = 1643722200 },
                new TankForStation { Id = 10, StationId = 4, ContainWhat = "Gas", Data = 16000, DateOfLastUpdate = 1643692800 },
                new TankForStation { Id = 11, StationId = 4, ContainWhat = "Petrol", Data = 24000, DateOfLastUpdate = 1643716200 },
                new TankForStation { Id = 12, StationId = 4, ContainWhat = "Diesel", Data = 26000, DateOfLastUpdate = 1643724600 },
                new TankForStation { Id = 13, StationId = 5, ContainWhat = "Gas", Data = 4000, DateOfLastUpdate = 1643703600 },
                new TankForStation { Id = 14, StationId = 5, ContainWhat = "Petrol", Data = 9000, DateOfLastUpdate = 1643712600 },
                new TankForStation { Id = 15, StationId = 5, ContainWhat = "Petrol", Data = 14000, DateOfLastUpdate = 1643725800 },
                new TankForStation { Id = 16, StationId = 1, ContainWhat = "Gas", Data = 10000, DateOfLastUpdate = 1643699200 },
                new TankForStation { Id = 17, StationId = 1, ContainWhat = "Diesel", Data = 10000, DateOfLastUpdate = 1643719200 }

            );

            builder.Entity<Kassa>().HasData(
                new Kassa { Id = 1, StationId = 1, ContainWhat = "Gas", Data = 32000, DateOfLastUpdate = 1643723400, DateOfLastIn = 1643716800 },
                new Kassa { Id = 2, StationId = 1, ContainWhat = "Petrol", Data = 15000, DateOfLastUpdate = 1643723400, DateOfLastIn = 1643716800 },
                new Kassa { Id = 3, StationId = 2, ContainWhat = "Diesel", Data = 42000, DateOfLastUpdate = 1643723400, DateOfLastIn = 1643716800 },
                new Kassa { Id = 4, StationId = 3, ContainWhat = "Petrol", Data = 53000, DateOfLastUpdate = 1643730000, DateOfLastIn = 1643726400 },
                new Kassa { Id = 5, StationId = 4, ContainWhat = "Gas", Data = 30000, DateOfLastUpdate = 1643730000, DateOfLastIn = 1643726400 },
                new Kassa { Id = 6, StationId = 4, ContainWhat = "Diesel", Data = 26000, DateOfLastUpdate = 1643730000, DateOfLastIn = 1643726400 },
                new Kassa { Id = 7, StationId = 4, ContainWhat = "Petrol", Data = 24000, DateOfLastUpdate = 1643730000, DateOfLastIn = 1643726400 },
                new Kassa { Id = 8, StationId = 5, ContainWhat = "Gas", Data = 4000, DateOfLastUpdate = 1643730000, DateOfLastIn = 1643726400 },
                new Kassa { Id = 9, StationId = 5, ContainWhat = "Petrol", Data = 23000, DateOfLastUpdate = 1643723400, DateOfLastIn = 1643716800 },
                new Kassa { Id = 10, StationId = 2, ContainWhat = "Gas", Data = 18000, DateOfLastUpdate = 1643730000, DateOfLastIn = 1643726400 },
                new Kassa { Id = 11, StationId = 1, ContainWhat = "Diesel", Data = 10000, DateOfLastUpdate = 1643723400, DateOfLastIn = 1643716800 }

            );
            base.OnModelCreating(builder);
        }
    }
}
