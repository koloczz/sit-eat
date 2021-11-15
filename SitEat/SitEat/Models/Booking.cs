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
        [Required]
        [ForeignKey("Table")]
        public int TableId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int TimeStart { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Telephone { get; set; }
    }
}
