using LoginApp.CORE.Entities;
using LoginApp.CORE.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.FirstName)
                 .HasColumnType("nvarchar")
                 .HasMaxLength(50);
            builder.Property(x => x.LastName)
                .HasMaxLength(50)
                .HasColumnType("nvarchar");
            builder.HasIndex(x => x.UserName)
                .IsUnique();
        }
    }
}
