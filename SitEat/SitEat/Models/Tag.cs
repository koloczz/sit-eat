using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SitEat.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
