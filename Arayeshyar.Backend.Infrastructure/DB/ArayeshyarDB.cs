using Arayeshyar.Backend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayeshyar.Backend.Infrastructure.DB
{
    public class ArayeshyarDB : DbContext
    {
        public DbSet<SystemAdmin>   SystemAdmins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BarberShopOwner> BarberShopOwners { get; set; }

        public ArayeshyarDB(DbContextOptions<ArayeshyarDB> options)
          : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SystemAdmin>().HasKey(k => k.Username);
            modelBuilder.Entity<Barber>().HasKey(m => m.MobileNumber);
            modelBuilder.Entity<BarberShopOwner>().HasKey(m => m.MobileNumber);
            modelBuilder.Entity<Customer>().HasKey(m => m.MobileNumber);


        }
    }
}
