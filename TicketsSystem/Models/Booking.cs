using System.ComponentModel.DataAnnotations.Schema;

namespace TicketsSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Seat { get; set; }
        public DateTime DateToPresent { get; set; }

        public double Amount { get; set; }
        public int TicketId { get; set; }

        [ForeignKey("TicketId")]
        public virtual Ticket ticket { get; set; }

    }
}
