using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketsSystem.Models;
using TicketsSystem.Models.ViewModels;

namespace TicketsSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TicketsSystem.Models.ViewModels.TicketViewmodel> TicketViewmodel { get; set; }
    }
}