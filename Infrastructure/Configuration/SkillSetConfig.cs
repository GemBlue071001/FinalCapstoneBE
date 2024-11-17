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
    public class SkillSetConfig : IEntityTypeConfiguration<SkillSet>
    {
        public void Configure(EntityTypeBuilder<SkillSet> builder)
        {
            builder.HasMany(o => o.JobSkillSets)
               .WithOne(o => o.SkillSet)
               .HasForeignKey(o => o.SkillSetId);

            builder.HasMany(o => o.SeekerSkillSets)
               .WithOne(o => o.SkillSet)
               .HasForeignKey(o => o.SkillSetId);

            builder.HasData(new SkillSet
            {
                Id = 1,
                Name = "Business Analyst",
                Shorthand = "BA",
                Description = "Business Analyst",
            },
             new SkillSet
             {
                 Id = 2,
                 Name = "C#",
                 Shorthand = "C#",
                 Description = "C#",
             },
             new SkillSet
             {
                 Id = 3,
                 Name = "Java Script",
                 Shorthand = "JS",
                 Description = "Java Script",
             },
             new SkillSet
             {
                 Id = 200,
                 Name = "Angular",
             },
             new SkillSet
             {
                 Id = 201,
                 Name = "AWS",
             },
             new SkillSet
             {
                 Id = 202,
                 Name = "Bridge Engineer",
             },
             new SkillSet
             {
                 Id = 203,
                 Name = "C++",
             },
             new SkillSet
             {
                 Id = 204,
                 Name = "CSS",
             },
             new SkillSet
             {
                 Id = 205,
                 Name = "Kotlin",
             },
             new SkillSet
             {
                 Id = 206,
                 Name = "Magento",
             },
             new SkillSet
             {
                 Id = 207,
                 Name = "MySQL",
             },
             new SkillSet
             {
                 Id = 208,
                 Name = "NextJS",
             },
             new SkillSet
             {
                 Id = 209,
                 Name = "OOP",
             },
             new SkillSet
             {
                 Id = 210,
                 Name = "PQA",
             },
             new SkillSet
             {
                 Id = 211,
                 Name = "ReactJS",
             },
             new SkillSet
             {
                 Id = 212,
                 Name = "Solution Architect",
             },
             new SkillSet
             {
                 Id = 213,
                 Name = "Security",
             },
             new SkillSet
             {
                 Id = 214,
                 Name = "TypeScript",
             },
             new SkillSet
             {
                 Id = 215,
                 Name = "Agile",
             },
             new SkillSet
             {
                 Id = 216,
                 Name = "ASP.NET",
             },
             new SkillSet
             {
                 Id = 217,
                 Name = "Big Data",
             },
             new SkillSet
             {
                 Id = 218,
                 Name = "Cloud",
             },
             new SkillSet
             {
                 Id = 219,
                 Name = "Data Analyst",
             },
             new SkillSet
             {
                 Id = 220,
                 Name = "DevSecOps",
             },
             new SkillSet
             {
                 Id = 221,
                 Name = "HTML5",
             },
             new SkillSet
             {
                 Id = 222,
                 Name = "JQuery",
             },
             new SkillSet
             {
                 Id = 223,
                 Name = "SQL",
             });

        }
    }
}
