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
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasMany(o => o.JobPosts)
               .WithOne(o => o.Company)
               .HasForeignKey(o => o.CompanyId);

            builder.HasMany(o => o.UserAccounts)
                .WithOne(o => o.Company)
                .HasForeignKey(o => o.CompanyId);

            builder.HasMany(o => o.Reviews)
                .WithOne(o => o.Company)
                .HasForeignKey(o => o.CompanyId);

            builder.HasOne(o => o.BusinessStream)
                .WithMany(o => o.Companys)
                .HasForeignKey(o => o.BusinessStreamId);

            builder.HasMany(o => o.FollowCompanys)
                .WithOne(o => o.Company)
                .HasForeignKey(o => o.CompanyId);

            builder.HasMany(o => o.FeedBacks)
                .WithOne(o => o.Company)
                .HasForeignKey(o => o.CompanyId);

            builder.HasData(new Company()
            {
                Id = 1,
                Address = "39 Vo Chi Cong Stress",
                City = "HCM",
                Country = "VietNam",
                WebsiteURL = "https://fpt.com/vi",
                CompanyName = "Fpt Software",
                NumberOfEmployees = 1000,
                EstablishedYear = 2008,
                CompanyDescription = "Tech Company",
                BusinessStreamId = 1,
            },
            new Company()
            {
                Id = 2,
                Address = "64 Le Van Si Stress",
                City = "HCM",
                Country = "VietNam",
                WebsiteURL = "https://fpt.com/vi",
                CompanyName = "High Tech",
                NumberOfEmployees = 50,
                EstablishedYear = 2008,
                CompanyDescription = "Tech Company",
                BusinessStreamId = 1,
            }
            );
           
        }
    }
}
