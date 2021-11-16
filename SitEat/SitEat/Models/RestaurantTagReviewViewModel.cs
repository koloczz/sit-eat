using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SitEat.Models
{
    public class RestaurantTagReviewViewModel
    {

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? ImagePath { get; set; }

        [Required]
        public string? OpeningTimes { get; set; }

        [Required]
        public List<string>? Tags { get; set; }

        [Required]
        public int? Score { get; set; }
    }
}
