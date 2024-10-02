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
    public class BusinessStreamConfig : IEntityTypeConfiguration<BusinessStream>
    {
        public void Configure(EntityTypeBuilder<BusinessStream> builder)
        {
            builder.HasMany(o => o.Companys)
              .WithOne(o => o.BusinessStream)
              .HasForeignKey(o => o.BusinessStreamId);

            builder.HasData(new BusinessStream
            {
                Id =1,
                BusinessStreamName = "Tech",
                Description = "Tech Industry",
                
            });
        }
    }
}
