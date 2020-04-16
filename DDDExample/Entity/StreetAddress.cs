using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDExample.Entity
{
    [Owned]
    public class StreetAddress
    {
        public string Street { get; set; }

        public string City { get; set; }
    }
}
