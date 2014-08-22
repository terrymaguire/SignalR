using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManager.Models
{
    public class Resource
    {
        public Resource()
        {
            Resources = new List<Resource>();
        }

        public Owner Owner { get; set; }
        public IList<Resource> Resources { get;set;}
    }
}
