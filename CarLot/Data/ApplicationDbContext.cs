using System;
using System.Collections.Generic;
using System.Text;
using CarLot.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarLot.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<SUV> SUVs { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .HasMany(r => r.Cars)
                .WithOne(u => u.ApplicationUser)
                .IsRequired();

            builder.Entity<ApplicationUser>()
               .HasMany(r => r.Trucks)
               .WithOne(u => u.ApplicationUser)
               .IsRequired();

            builder.Entity<ApplicationUser>()
               .HasMany(r => r.SUVs)
               .WithOne(u => u.ApplicationUser)
               .IsRequired();

            builder.Entity<ApplicationUser>()
               .HasMany(r => r.Buses)
               .WithOne(u => u.ApplicationUser)
               .IsRequired();

            builder.Entity<ApplicationUser>()
               .HasMany(r => r.Motorcycles)
               .WithOne(u => u.ApplicationUser)
               .IsRequired();

            base.OnModelCreating(builder);

            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>
            { Name="Online Seller", NormalizedName="ONLINE SELLER", Id = 1, ConcurrencyStamp= Guid.NewGuid().ToString() });
            
            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>
            { Name = "Dealership", NormalizedName = "DEALERSHIP", Id = 2, ConcurrencyStamp = Guid.NewGuid().ToString() });

            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>
            { Name = "Private Party", NormalizedName = "PRIVATE PARTY", Id = 3, ConcurrencyStamp = Guid.NewGuid().ToString() });

            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int>
            { Name = "Buyer", NormalizedName = "BUYER", Id = 4, ConcurrencyStamp = Guid.NewGuid().ToString() });
        }
    }
}
