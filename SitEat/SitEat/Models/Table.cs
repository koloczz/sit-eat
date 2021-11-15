using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SitEat.Models
{
    public class Table
    {
        public int Id { get; set; }

        [ForeignKey("Restaurant")]
        [Required]
        public int? RestaurantId { get; set; }

        [Required]
        public int? NumberOfSits { get; set; }

        [Required]
        public int? PositionX { get; set; }

        [Required]
        public int? PositionY { get; set; }
        public ICollection<Booking> Bookings { get; set; }

    }
}
