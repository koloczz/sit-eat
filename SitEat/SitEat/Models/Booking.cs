using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SitEat.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required, ForeignKey("Table")]
        public int TableId { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required, Display(Name = "Time Start")]
        public int TimeStart { get; set; }

        [Required, StringLength(30, MinimumLength = 1), RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Name { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }
    }
}
