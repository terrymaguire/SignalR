using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManager.Models
{
    public class Booking
    {
        public Booking()
        {
            TimeSlots = new List<TimeSlot>();
        }

        public string Id { get; set; }

        public Customer Customer { get; set; }
        public Resource Resource { get; set; }
        public DateTime BookingDate { get; set; }
        public IList<TimeSlot> TimeSlots { get; set; }
    }
}
