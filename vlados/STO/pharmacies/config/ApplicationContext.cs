using carservice.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.config
{
    public class MyApplicationContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Carservice> Carservice => Set<Carservice>();
        public DbSet<Worker> Workers => Set<Worker>();
        public DbSet<Client> Clients => Set<Client>();
        public MyApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ADCLG1;Database=STO2281337;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Client>()
                .HasMany(u => u.Orders)
                .WithOne(u => u.Client)
                .HasForeignKey(u => u.ClientId);

            modelBuilder.Entity<Carservice>()
                .HasMany(u => u.Orders)
                .WithOne(u => u.CarService)
                .HasForeignKey(u => u.CarServiceId);


           

            modelBuilder.Entity<Worker>()
                .HasMany(u => u.Carservice)
                .WithOne(u => u.Worker)
                .HasForeignKey(u => u.Idworker);
        }
    }
}
