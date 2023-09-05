using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelProject.DAL.Mapping;
using TelProject.DATA.Entities;

namespace TelProject.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=TelProjectDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Address>()
            //    .HasOne(x => x.Person)
            //    .WithMany(x => x.Addresses)
            //    .HasForeignKey(x => x.PersonId);

            modelBuilder.ApplyConfiguration(new PersonMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
