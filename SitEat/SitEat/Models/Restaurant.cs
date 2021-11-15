using System.ComponentModel.DataAnnotations;

namespace SitEat.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? ImagePath { get; set; }

        [Required]
        public string? Tags { get; set; }

        [Required]
        public string? OpeningTimes { get; set; }
    }
}
