using LoginApp.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Mapping
{
    public class TextMapping : IEntityTypeConfiguration<Text>
    {
        public void Configure(EntityTypeBuilder<Text> builder)
        {
            builder.HasOne(x=>x.User)
                .WithMany(x=>x.Texts)
                .HasForeignKey(x=>x.UserId);
        }
    }
}
