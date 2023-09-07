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
    public class UserSeedData : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData(
               new Users() { Id = 1, FirstName = "Ali", LastName = "Gündüz", UserName = "agunduz", Password = "a.gunduz1", Account = Account.Admin },
               new Users() { Id = 2, FirstName = "Emrah", LastName = "Yaşar", UserName = "eyasar", Password = "e.yasar1" },
               new Users() { Id = 3, FirstName = "Savaş", LastName = "Kurt", UserName = "skurt", Password = "savas.kurt1903" }
               );
        }
    }
}
