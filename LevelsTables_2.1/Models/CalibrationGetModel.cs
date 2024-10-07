namespace LevelsTables.Models
{
    public class CalibrationGetModel
    {
        public decimal Level { get; set; }
        public decimal Volume { get; set; }
        public decimal ratio { get; set; }
        public long timeOfUploadOrUpdate { get; set; }
    }
}
