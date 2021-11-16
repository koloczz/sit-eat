using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SitEat.Models
{
    public class RestaurantDetailsViewModel
    {

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? ImagePath { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? OpeningTimes { get; set; }

        [Required]
        public List<Table>? Tables { get; set; }

        [Required]
        public List<Tag>? Tags { get; set; }

        [Required]
        public List<MenuItem>? MenuItems { get; set; }

        [Required]
        public List<Review>? Reviews { get; set; }
    }
}
