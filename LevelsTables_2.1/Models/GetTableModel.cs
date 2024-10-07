using AlisonicLevels.Models;
using System.Collections.Generic;

namespace LevelsTables.Models
{
    public class GetTableModel
    {
        public int countOfRows { get; set; }
        public List<CalibrationGetModel> CalibrationList { get; set; }

    }
}
