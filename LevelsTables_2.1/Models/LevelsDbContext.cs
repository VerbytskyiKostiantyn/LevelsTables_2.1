using AlisonicLevels.Models;
using Levels.Models;
using Microsoft.EntityFrameworkCore;
namespace LevelsTables.Models
{
    public class LevelsDbContext : DbContext
    {
        public LevelsDbContext(DbContextOptions<LevelsDbContext> options) : base(options)
        {

        }

        public DbSet<Tank> Tanks { get; set; }
        public DbSet<Calibration> Calibrations { get; set; }

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
                });
            base.OnModelCreating(builder);
        }
    }
}
