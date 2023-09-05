using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelProject.DATA.Entities;

namespace TelProject.DAL.Mapping
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(a => a.City).HasMaxLength(13);
            builder.Property(a=>a.Town).HasMaxLength(20);

            builder.HasData(
                new Address() { Id = 1, City = "Kastamonu", Town = "Tosya", AddressDetail = "YeşilYurt", PersonId = 1 },
                new Address() { Id = 2, City = "Ankara", Town = "Gölbaşı", AddressDetail = "Karanfil", PersonId = 1 },
                new Address() { Id = 3, City = "Muğla", Town = "Fethiye", AddressDetail = "Taşyaka", PersonId = 2 }
                );
        }
    }
}
