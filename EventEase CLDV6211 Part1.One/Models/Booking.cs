namespace EventEase_CLDV6211_Part1.One.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int BookingId { get; set; }

        public int EventId { get; set; }

        public DateTime BookingDate { get; set; }
    }
}
