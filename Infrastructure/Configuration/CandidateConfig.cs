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
    public class CandidateConfig : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {

            builder.HasOne(o => o.CampaignJob)
               .WithMany(o => o.Candidates)
               .HasForeignKey(o => o.CampaignJobId);
               //.OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.User)
              .WithMany(o => o.Candidates)
              .HasForeignKey(o => o.UserId);
            //.OnDelete(DeleteBehavior.Cascade);

            builder.HasQueryFilter(x => !x.IsDeleted);

            builder.Property(b => b.CreatedDate)
                   .HasDefaultValue(DateTime.UtcNow)
                   .ValueGeneratedOnAdd();
        }
    }
}
