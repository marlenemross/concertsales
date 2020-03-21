using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Concert
    {
        public String Name { get; set; }
        public DateTime ConcertDate { get; set; }
        public int TicketsSold { get; set; }
        public int TicketsAvailable { get; set; }
        public List<Musician> musicians { get; set; }


    }
}
