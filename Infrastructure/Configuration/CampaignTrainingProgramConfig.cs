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
    public class CampaignTrainingProgramConfig : IEntityTypeConfiguration<CampaignTrainingProgram>
    {
        public void Configure(EntityTypeBuilder<CampaignTrainingProgram> builder)
        {
            builder.HasOne(o => o.TrainingProgram)
               .WithMany(o => o.CampaignTrainingPrograms)
               .HasForeignKey(o => o.TrainingProgramId);

            builder.HasOne(o => o.Campaign)
               .WithMany(o => o.CampaignTrainingPrograms)
               .HasForeignKey(o => o.CampaignId);
        }
    }
}
