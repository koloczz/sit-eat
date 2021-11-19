namespace SitEat.Models
{
    public class TableInfo
    {
        public bool IsTable { get; set; }
        public int TableId { get; set; }
        public int? NumberOfSits { get; set; }
        public int? PositionX { get; set; }
        public int? PositionY { get; set; }
        public bool IsBooked { get; set; }

    }
}
