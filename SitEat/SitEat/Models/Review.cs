using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SitEat.Models
{
    public class Review
    {
        public int Id { get; set; }

        [ForeignKey("Restaurant")]
        [Required]
        public int? RestaurantId { get; set; }

        [Required]
        public string? Author { get; set; }

        [Required]
        public int? Score { get; set; }

        [Required]
        public string? Text { get; set; }
    }
}
