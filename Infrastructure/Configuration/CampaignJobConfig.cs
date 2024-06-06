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
    public class CampaignJobConfig : IEntityTypeConfiguration<CampaignJob>
    {
        public void Configure(EntityTypeBuilder<CampaignJob> builder)
        {
            builder.HasOne(o => o.Job)
               .WithMany(o => o.CampaignJobs)
               .HasForeignKey(o => o.JobId);

            builder.HasOne(o => o.Campaign)
               .WithMany(o => o.CampaignJobs)
               .HasForeignKey(o => o.JobId);
        }
    }
}
