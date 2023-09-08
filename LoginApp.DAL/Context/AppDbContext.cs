using LoginApp.CORE.Entities;
using LoginApp.DAL.Mapping;
using LoginApp.DAL.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Text> Texts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=LoginDB;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-LAUF8V8;Database=LoginDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TextMapping())
                        .ApplyConfiguration(new UserMapping())
                        .ApplyConfiguration(new UserSeedData())
                        .ApplyConfiguration(new TextSeedData());


            base.OnModelCreating(modelBuilder);
        }
    }
}
