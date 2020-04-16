using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDExample.Entity
{
    public class Distributor
    {
        public int Id { get; set; }

        public ICollection<StreetAddress> ShippingAddress { get; set; }
    }
}
