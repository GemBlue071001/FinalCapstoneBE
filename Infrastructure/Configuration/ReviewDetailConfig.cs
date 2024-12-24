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
    public class ReviewDetailConfig : IEntityTypeConfiguration<ReviewDetail>
    {
        public void Configure(EntityTypeBuilder<ReviewDetail> builder)
        {
            /*builder.HasOne(o => o.Review)
                .WithMany(o => o.ReviewDetails)
                .HasForeignKey(o => o.ReviewId);*/
        }
    }
}
