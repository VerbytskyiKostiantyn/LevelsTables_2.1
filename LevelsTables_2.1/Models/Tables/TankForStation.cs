using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LevelsTables.Models.Tables
{
    public class TankForStation
    {
        [Key]
        public int Id { get; set; }
        public int StationId { get; set; }
        public Station Station { get; set; }
        public string ContainWhat { get; set; }
        public long Data { get; set; }
        public long DateOfLastUpdate { get; set; }
        [NotMapped]
        public string Color { get; set; }
    }
}
