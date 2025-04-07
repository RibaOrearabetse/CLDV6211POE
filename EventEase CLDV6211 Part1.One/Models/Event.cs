namespace EventEase_CLDV6211_Part1.One.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        public int EventId { get; set; }

        [Required]
        [StringLength(255)]
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public int? VenueId { get; set; }
    }
}
