using AlisonicLevels.Models;
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
                new Station { Id = 1, Name = "Station 1" },
                new Station { Id = 2, Name = "Station 2" },
                new Station { Id = 3, Name = "Station 3" },
                new Station { Id = 4, Name = "Station 4" },
                new Station { Id = 5, Name = "Station 5" }
            );

            builder.Entity<TankForStation>().HasData(
                new TankForStation { Id = 1, StationId = 1, ContainWhat = "Gas", Data = 10000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 2, StationId = 1, ContainWhat = "Gas", Data = 12000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 3, StationId = 1, ContainWhat = "Petrol", Data = 15000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 4, StationId = 2, ContainWhat = "Diesel", Data = 20000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 5, StationId = 2, ContainWhat = "Diesel", Data = 22000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 6, StationId = 2, ContainWhat = "Gas", Data = 18000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 7, StationId = 3, ContainWhat = "Petrol", Data = 25000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 8, StationId = 3, ContainWhat = "Petrol", Data = 28000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 9, StationId = 4, ContainWhat = "Gas", Data = 14000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 10, StationId = 4, ContainWhat = "Gas", Data = 16000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 11, StationId = 4, ContainWhat = "Petrol", Data = 24000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 12, StationId = 4, ContainWhat = "Diesel", Data = 26000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 13, StationId = 5, ContainWhat = "Gas", Data = 4000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 14, StationId = 5, ContainWhat = "Petrol", Data = 9000, DateOfLastUpdate = DateTime.Now.AddDays(-1) },
                new TankForStation { Id = 15, StationId = 5, ContainWhat = "Petrol", Data = 14000, DateOfLastUpdate = DateTime.Now.AddDays(-1) }
            );

            builder.Entity<Kassa>().HasData(
                new Kassa { Id = 1, StationId = 1, ContainWhat = "Gas", Data = 22000, DateOfLastUpdate = DateTime.Now.AddDays(-1), DateOfLastIn = DateTime.Now.AddDays(-2) },
                new Kassa { Id = 2, StationId = 1, ContainWhat = "Petrol", Data = 15000, DateOfLastUpdate = DateTime.Now.AddDays(-1), DateOfLastIn = DateTime.Now.AddDays(-2) },
                new Kassa { Id = 3, StationId = 2, ContainWhat = "Diesel", Data = 42000, DateOfLastUpdate = DateTime.Now.AddDays(-1), DateOfLastIn = DateTime.Now.AddDays(-2) },
                new Kassa { Id = 4, StationId = 3, ContainWhat = "Petrol", Data = 53000, DateOfLastUpdate = DateTime.Now, DateOfLastIn = DateTime.Now.AddDays(-1) },
                new Kassa { Id = 5, StationId = 4, ContainWhat = "Gas", Data = 30000, DateOfLastUpdate = DateTime.Now, DateOfLastIn = DateTime.Now.AddDays(-1) },
                new Kassa { Id = 6, StationId = 4, ContainWhat = "Diesel", Data = 26000, DateOfLastUpdate = DateTime.Now, DateOfLastIn = DateTime.Now.AddDays(-1) },
                new Kassa { Id = 7, StationId = 4, ContainWhat = "Petrol", Data = 24000, DateOfLastUpdate = DateTime.Now, DateOfLastIn = DateTime.Now.AddDays(-1) },
                new Kassa { Id = 8, StationId = 5, ContainWhat = "Gas", Data = 4000, DateOfLastUpdate = DateTime.Now, DateOfLastIn = DateTime.Now.AddDays(-1) },
                new Kassa { Id = 9, StationId = 5, ContainWhat = "Petrol", Data = 23000, DateOfLastUpdate = DateTime.Now.AddDays(-1), DateOfLastIn = DateTime.Now.AddDays(-1) }

            );
            base.OnModelCreating(builder);
        }
    }
}
