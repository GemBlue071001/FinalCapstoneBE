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
    public class UserServiceConfig : IEntityTypeConfiguration<UserService>
    {
        public void Configure(EntityTypeBuilder<UserService> builder)
        {
            builder.HasOne(x => x.UserAccount)
                    .WithMany(x => x.UserServices)
                    .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Service)
                  .WithMany(x => x.UserServices)
                  .HasForeignKey(x => x.ServiceId);
        }
    }
}
