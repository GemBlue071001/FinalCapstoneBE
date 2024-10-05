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
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasOne(o => o.UserAccount)
             .WithMany(o => o.Reviews)
             .HasForeignKey(o => o.UserId);

            builder.HasOne(o => o.Company)
             .WithMany(o => o.Reviews)
             .HasForeignKey(o => o.CompanyId);
        }
    }
}
