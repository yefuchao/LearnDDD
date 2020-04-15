using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDExample.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public Address Address { get; set; }
    }
}
