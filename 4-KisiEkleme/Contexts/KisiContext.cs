using _4_KisiEkleme.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_KisiEkleme.Contexts
{
    public class KisiContext:DbContext
    {
        public DbSet<Kisi> Kisis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=KisiDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>().HasIndex(x => x.Tel).IsUnique();
        }
    }
}
