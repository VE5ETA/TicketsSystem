
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsSystem.Models.ViewModels
{
    [Keyless]
    public class TicketViewmodel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Logo { get; set; }
    }
}
