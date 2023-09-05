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
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(a=>a.FirstName).HasMaxLength(50);
            //builder.Property(a => a.CreateDate).HasDefaultValue(DateTime.Now);

            builder.HasData(
                new Person() { Id = 1, FirstName = "Sefa", LastName = "Attila", Phone = "552 828 1903" },
                new Person() { Id = 2, FirstName = "Ahmet", LastName = "Yılmaz", Phone = "552 828 1903" }
                );
        }
    }
}
