using LoginApp.CORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.SeedData
{
    public class TextSeedData : IEntityTypeConfiguration<Text>
    {
        public void Configure(EntityTypeBuilder<Text> builder)
        {
            builder.HasData(
                new Text() { Id = 1, Title = "Dene", TextDetail = "DenemeDeneme", UserId = 2 },
                new Text() { Id = 2, Title = "Kulüp", TextDetail = "Beşiktaş", UserId = 3 }
                );
        }
    }
}
