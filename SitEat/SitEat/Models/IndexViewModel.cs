using System.Collections.Generic;

namespace SitEat.Models
{
    public class IndexViewModel
    {
        public List<string> ListOfTags { get; set; }

        public List<RestaurantTagReviewViewModel> Restaurants { get; set; }
    }
}
