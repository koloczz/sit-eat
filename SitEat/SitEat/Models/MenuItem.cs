using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SitEat.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [ForeignKey("Restaurant")]
        [Required]
        public int? RestaurantId { get; set; }

        [Required]
        public decimal? Price { get; set; }
    }
}
