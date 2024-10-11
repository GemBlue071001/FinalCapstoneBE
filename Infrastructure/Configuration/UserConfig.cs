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
            

            //builder.HasQueryFilter(x => !x.IsDeleted);

            builder
            .HasIndex(q => q.UserName)
            .IsUnique();
            var user1 = CreatePasswordHash("User1");
            var user2 = CreatePasswordHash("User2");
            var employer = CreatePasswordHash("Employer");
            var admin = CreatePasswordHash("Admin");


            builder.HasMany(o => o.JobPosts)
                .WithOne(o => o.UserAccount)
                .HasForeignKey(o => o.UserId);

            builder.HasMany(o => o.JobPostActivitys)
                .WithOne(o => o.UserAccount)
                .HasForeignKey(o => o.UserId);

            builder.HasOne(o => o.Company)
               .WithMany(o => o.UserAccounts)
               .HasForeignKey(o => o.CompanyId);

            builder.HasMany(o => o.FollowCompanys)
                .WithOne(o => o.UserAccount)
                .HasForeignKey(o => o.UserId);



            builder.HasData
                (
                  new UserAccount
                  {
                      Id = 1,
                      UserName = "User1",
                      PasswordHash = user1.PasswordHash,
                      PasswordSalt = user1.PasswordSalt,
                      LastName = "User1",
                      Role = Role.JobSeeker,
                      Email = "User1@gmail.com",
                  },
                  new UserAccount
                  {
                      Id = 2,
                      UserName = "User2",
                      PasswordHash = user2.PasswordHash,
                      PasswordSalt = user2.PasswordSalt,
                      LastName = "User2",
                      Role = Role.JobSeeker,
                      Email = "User2@gmail.com",
                  },
                  new UserAccount
                  {
                      Id = 3,
                      UserName = "Employer",
                      PasswordHash = employer.PasswordHash,
                      PasswordSalt = employer.PasswordSalt,
                      LastName = "Employer",
                      Role = Role.Employer,
                      Email = "Employer@gmail.com",
                  },
                  new UserAccount
                  {
                      Id = 4,
                      UserName = "Admin",
                      PasswordHash = admin.PasswordHash,
                      PasswordSalt = admin.PasswordSalt,
                      LastName = "Admin",
                      Role = Role.Admin,
                      Email = "Admin@gmail.com",
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
