using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingManager.Models
{
    public class Booking
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AllDay { get; set; }
    }
}