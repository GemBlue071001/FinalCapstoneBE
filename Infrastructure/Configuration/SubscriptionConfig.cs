using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class SubscriptionConfig : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            //builder.HasOne(o => o.UserAccount)
            //   .WithMany(o => o.Subscriptions)
            //   .HasForeignKey(o => o.UserId);
        }
    }
}
