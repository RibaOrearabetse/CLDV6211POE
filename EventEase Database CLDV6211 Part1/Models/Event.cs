namespace EventEase_Database_CLDV6211_Part1.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Foreign key
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
    }
}
