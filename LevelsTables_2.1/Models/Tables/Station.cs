using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LevelsTables.Models.Tables
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TankForStation> TankForStations { get; set; }
        public List<Kassa> Kassas { get; set; }
        [NotMapped]
        public long DisplayDataOfDieselKassa {  get; set; }
        [NotMapped]
        public DateTime DisplayLastInOfDieselKassa { get; set; }
        [NotMapped]
        public long DisplayDataOfPetrolKassa {  get; set; }
        [NotMapped]
        public DateTime DisplayLastInOfPetrolKassa { get; set; }
        [NotMapped]
        public long DisplayDataOfGasKassa {  get; set; }
        [NotMapped]
        public DateTime DisplayLastInOfGasKassa { get; set; }
        [NotMapped]
        public string ColorOfDieselKassa { get; set; }
        [NotMapped]
        public string ColorOfPetrolKassa { get; set; }
        [NotMapped]
        public string ColorOfGasKassa { get; set; }
        [NotMapped]
        public int CountOfDieselTanks { get; set; }
        [NotMapped]
        public int CountOfPetrolTanks { get; set; }
        [NotMapped]
        public int CountOfGasTanks { get; set; }
    }
}
