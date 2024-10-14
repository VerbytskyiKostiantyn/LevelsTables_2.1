using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LevelsTables.Models.Tables
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TankForStation> TankForStations { get; set; }
        public List<Kassa> Kassas { get; set; }

    }
}
