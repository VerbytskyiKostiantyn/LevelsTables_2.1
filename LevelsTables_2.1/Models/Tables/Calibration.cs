using CsvHelper.Configuration.Attributes;
using Levels.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlisonicLevels.Models
{
    public class Calibration
    {
        [Key]
        [Ignore]
        public int Id { get; set; }
        [Ignore]
        public int TankId {  get; set; }
        [Ignore]
        [JsonIgnore]
        public Tank Tank { get; set; }
        [Name("level")]
        public decimal Level { get; set; }
        [Name("volume")]
        public decimal Volume { get; set; }
        [Ignore]
        public decimal? modificator { get; set; }
        [Ignore]
        public decimal ratio { get; set; }
        [Ignore]
        public long timeOfUploadOrUpdate { get; set; }
    }
}
