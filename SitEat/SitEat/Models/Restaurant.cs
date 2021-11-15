using System.Collections.Generic;
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
        public string? OpeningTimes { get; set; }
        public ICollection<Table> Tables { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
