using AlisonicLevels.Models;
using Levels.Models;
using System.Collections.Generic;

namespace LevelsTables.Models.View_Models
{
    public class InfoVM
    {
        public Tank Tank { get; set; }
        public List<Calibration> Calibrations { get; set; }
        public List<long> AllUploadTimes { get; set; }
        public long CurrentTableTime { get; set; }
    }
}