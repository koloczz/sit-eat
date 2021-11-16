using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SitEat.Models
{
    public class TableInfo
    {
        public int TableId { get; set; }
        public int? NumberOfSits { get; set; }
        public int? PositionX { get; set; }
        public int? PositionY { get; set; }
        public bool IsBooked { get; set; }

    }
}
