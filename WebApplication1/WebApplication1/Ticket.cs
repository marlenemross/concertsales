using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Ticket
    {
        public Concert Concert { get; set; }
        public Decimal Price { get; set; }
        public String Owner { get; set; }
    }
}
