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
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(new Location
            {
                City = "HO CHI MINH",
                Id = 1,
            },
            new Location
            {
                City = "HA NOI",
                Id = 2,
            },
            new Location
            {
                City = "DA NANG",
                Id = 3,
            },
             new Location
             {
                 City = "HAI PHONG",
                 Id = 4,
             },
              new Location
              {
                  City = "CAN THO",
                  Id = 5,
              },
               new Location
               {
                   City = "NHA TRANG",
                   Id = 6,
               });
        }
    }
}
