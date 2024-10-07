using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AlisonicLevels.Models;

namespace Levels.Models
{
    public enum ProbeType
    {
        Alisonic,
        VeederRoot,
        Sibylla
    }
    public class Tank
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [StringLength(20)]
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [StringLength(100)]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Используется")]
        public bool Active { get; set; }
        [Range(0, 999999999.99)]
        [Display(Name = "Максимальный объем")]
        public decimal? MaxVolume { get; set; }
        [Range(0, 999999999.99)]
        [Display(Name = "Сдвиг")]
        public decimal? Product_zero { get; set; }
        [Range(0, 999999999.99)]
        [Display(Name = "Сдвиг воды")]
        public decimal? Water_zero { get; set; }
        [Range(0, 999999999.99)]
        [Display(Name = "Опасный объем")]
        public decimal? Alert_Level { get; set; }
        [Display(Name = "Номенклатура")]
        [ForeignKey("FuelId")]
        public int? FuelID { get; set; }
        [ForeignKey("StationId")]
        [Display(Name = "Станция")]
        public int? StationID { get; set; }
        [Display(Name = "Номер резервуара")]
        public int TankNumber { get; set; }
        [Display(Name = "Уніфікований номер резервуара")]
        [StringLength(20)]
        public string TankUID { get; set; }
        [Display(Name = "Серійний (ідентифікаційний) номер рівнеміра")]
        [StringLength(20)]
        public string ProbeSerial { get; set; }
        [Display(Name = "Тип рівнеміра")]
        public ProbeType? Probetype { get; set; }
        [Display(Name = "Зовнішній ідентифікатор рівнеміра")]
        [StringLength(50)]
        public string ExternalProbeId { get; set; }

        public List<Calibration> Calibrations { get; set; }
    }
}
