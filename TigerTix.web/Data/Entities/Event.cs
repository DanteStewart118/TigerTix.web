using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TigerTix.web.Data.Entities
{
    public class Event
    {
        public int ID { get; set; }

        public String eventName { get; set; }

        public String date { get; set; }

        public String desc { get; set; }

        public String location { get; set; }

        public double ticketPrice { get; set; }
    }
}
