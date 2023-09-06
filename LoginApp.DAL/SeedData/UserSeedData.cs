using LoginApp.CORE.Entities;
using LoginApp.CORE.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.SeedData
{
    public class UserSeedData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
               new User() { Id = 1, FirstName = "Ali", LastName = "Gündüz", UserName = "agunduz", Password = "a.gunduz1", Account = Account.Admin },
               new User() { Id = 2, FirstName = "Emrah", LastName = "Yaşar", UserName = "eyasar", Password = "e.yasar1" },
               new User() { Id = 3, FirstName = "Savaş", LastName = "Kurt", UserName = "skurt", Password = "savas.kurt1903" }
               );
        }
    }
}
