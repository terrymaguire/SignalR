using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManager.Models
{
    public class Customer
    {
        public Customer()
        {
            Contacts = new List<Contact>();
        }

        public string Name { get; set; }

        public IList<Contact> Contacts { get; set; }
    }
}
