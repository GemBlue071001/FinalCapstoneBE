using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class CompanyLocationConfig : IEntityTypeConfiguration<CompanyLocation>
    {
        public void Configure(EntityTypeBuilder<CompanyLocation> builder)
        {
            builder.HasOne(o => o.Company)
               .WithMany(o => o.CompanyLocations)
               .HasForeignKey(o => o.CompanyId);

            builder.HasOne(o => o.Location)
                 .WithMany(o => o.CompanyLocations)
                 .HasForeignKey(o => o.CompanyId);
        }
    }
}
