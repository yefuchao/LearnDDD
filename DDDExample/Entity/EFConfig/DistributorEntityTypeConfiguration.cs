using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDExample.Entity.EFConfig
{
    public class DistributorEntityTypeConfiguration : IEntityTypeConfiguration<Distributor>
    {
        public void Configure(EntityTypeBuilder<Distributor> builder)
        {
            builder.OwnsMany(p => p.ShippingAddress, a =>
             {
                 //a.WithOwner().HasForeignKey("OwnerId");
                 a.Property<int>("Id");
                 a.HasKey("Id");
             });
        }
    }
}
