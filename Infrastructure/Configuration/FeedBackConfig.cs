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
    public class FeedBackConfig : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.HasOne(x => x.Company)
                .WithMany(x => x.FeedBacks)
                .HasForeignKey(x => x.CompanyId);

            builder.HasOne(x => x.UserAccount)
               .WithMany(x => x.FeedBacks)
               .HasForeignKey(x => x.UserId);
        }
    }
}
