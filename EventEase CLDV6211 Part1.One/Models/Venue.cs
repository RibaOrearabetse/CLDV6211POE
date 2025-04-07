namespace EventEase_CLDV6211_Part1.One.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venue")]
    public partial class Venue
    {
        public int VenueId { get; set; }

        [Required]
        [StringLength(255)]
        public string VenueName { get; set; }

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        public int Capacity { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; }
    }
}
