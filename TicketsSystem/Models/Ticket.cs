namespace TicketsSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public DateTime LastUpdated { get; set; }
        = DateTime.Now;
    }
}
