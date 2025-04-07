using Microsoft.EntityFrameworkCore;
using EventEase_Database_CLDV6211_Part1.Models;
using System.Collections.Generic;

namespace EventEase_Database_CLDV6211_Part1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
