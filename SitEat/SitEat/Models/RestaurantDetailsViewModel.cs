using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SitEat.Models
{
    public class RestaurantDetailsViewModel
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? ImagePath { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? OpeningTimes { get; set; }

        [Required]
        public double? Rating { get; set; }

        [Required]
        public ICollection<TableInfo>? TableInfos { get; set; }

        [Required]
        public ICollection<Tag>? Tags { get; set; }

        [Required]
        public ICollection<MenuItem>? MenuItems { get; set; }

        [Required]
        public ICollection<Review>? Reviews { get; set; }

        public bool IsInstantReservationChosen { get; set; }

        public int? FilterHour { get; set; }

        public DateTime? FilterDate { get; set; }

        public int? FilterPeople { get; set; }
    }
}
