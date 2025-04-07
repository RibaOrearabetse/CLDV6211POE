namespace EventEase_Database_CLDV6211_Part1.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string AttendeeName { get; set; }
        public string Email { get; set; }

        // Foreign key
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
