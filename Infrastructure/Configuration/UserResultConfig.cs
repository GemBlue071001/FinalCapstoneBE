using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class UserResultConfig : IEntityTypeConfiguration<UserResult>
    {
        public void Configure(EntityTypeBuilder<UserResult> builder)
        {
            builder.HasOne(o => o.User)
                  .WithMany(o => o.UserResults)
                  .HasForeignKey(o => o.UserId);
            //.OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Program)
               .WithMany(o => o.UserResults)
               .HasForeignKey(o => o.ProgramId);
            //.OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(o => o.UserResultDetails)
                  .WithOne(o => o.UserResult)
                  .HasForeignKey(o => o.UserResultId);
            //.OnDelete(DeleteBehavior.Cascade);

            //builder.HasQueryFilter(a => !a.User.IsDeleted);

        }
    }
}
