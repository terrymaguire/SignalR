using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManager.Models
{
    public class Availability
    {
        public Availability()
        {
            TimeSlots = new List<TimeSlot>();
        }

        public string Id { get; set; }

        public Resource Resource { get; set; }
        public DateTime AvailabilityDate { get; set; }
        public IList<TimeSlot> TimeSlots { get; set; }
        public AvailabilityStatus AvailabilityStatus { get; set; }
    }
}
