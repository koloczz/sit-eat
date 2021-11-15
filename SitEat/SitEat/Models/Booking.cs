using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SitEat.Models
{
    public class Booking
    {
        public int Id { get; set; }
        [ForeignKey("Table")]
        public int TableId { get; set; }
        public DateTime Date { get; set; }
        public int TimeStart { get; set; }
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
    }
}
