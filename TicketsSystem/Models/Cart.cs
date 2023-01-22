namespace TicketsSystem.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Seat { get; set; }
        public DateTime Date { get; set; }

        public double Amount { get; set; }
        public int TicketId { get; set; }


    }
}
