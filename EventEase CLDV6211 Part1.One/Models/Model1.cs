using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EventEase_CLDV6211_Part1.One.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Booking")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<EventEase_CLDV6211_Part1.One.Models.Event> Events { get; set; }

        public System.Data.Entity.DbSet<EventEase_CLDV6211_Part1.One.Models.Venue> Venues { get; set; }
    }
}
