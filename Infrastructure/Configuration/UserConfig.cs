using Application.Services;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.HasOne(o => o.CampaignJob)
                .WithMany(o => o.Interns)
                .HasForeignKey(o => o.CampaignJobId);

            builder.HasMany(o => o.Tasks)
                .WithOne(o => o.Owner)
                .HasForeignKey(o => o.UserId);

            builder
            .HasIndex(q => q.UserName)
            .IsUnique();
            var hr1Pass = CreatePasswordHash("HR1");
            var ic1Pass = CreatePasswordHash("IC1");
            var mentor1Pass = CreatePasswordHash("mentor1");
            var intern1Pass = CreatePasswordHash("intern1");

            builder.HasData
                (
                  new UserAccount
                  {
                      Id = 1,
                      UserName = "HRAccount",
                      PasswordHash = hr1Pass.PasswordHash,
                      PasswordSalt = hr1Pass.PasswordSalt,
                      LastName = "HRAccount",
                      Role = Role.HRManager,
                      Email = "HRAccount@gmail.com",
                  },
                  new UserAccount
                  {
                      Id = 2,
                      UserName = "ICAccount",
                      PasswordHash = ic1Pass.PasswordHash,
                      PasswordSalt = ic1Pass.PasswordSalt,
                      LastName = "ICAccount",
                      Role = Role.InternshipCoordinators,
                      Email = "ICAccountt@gmail.com",
                  },
                  new UserAccount
                  {
                      Id = 3,
                      UserName = "mentorAccount",
                      PasswordHash = mentor1Pass.PasswordHash,
                      PasswordSalt = mentor1Pass.PasswordSalt,
                      LastName = "mentorAccount",
                      Role = Role.Mentor,
                      Email = "mentorAccount@gmail.com",
                  },
                  new UserAccount
                  {
                      Id = 4,
                      UserName = "InternAccount",
                      PasswordHash = intern1Pass.PasswordHash,
                      PasswordSalt = intern1Pass.PasswordSalt,
                      LastName = "InternAccount",
                      Role = Role.Intern,
                      Email = "InternAccount@gmail.com",
                  }
                );
        }

        private PasswordDTO CreatePasswordHash(string password)
        {
            PasswordDTO pass = new PasswordDTO();
            using (var hmac = new HMACSHA512())
            {
                pass.PasswordSalt = hmac.Key;
                pass.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
            return pass;
        }
    }
}
