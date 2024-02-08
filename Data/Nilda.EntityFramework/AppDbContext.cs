using Microsoft.EntityFrameworkCore;
using Nilda.EntityFrameworkCore.Entities;
using Nilda.EntityFrameworkCore.SeedConfiguration;
using System;

namespace Nilda.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>() 
                .HasMany(r => r.Regions) 
                .WithOne(s => s.Country)
                .HasForeignKey(t => t.CountryId);

            modelBuilder.Entity<Country>().HasData(CountrySeedData.GetCountrySeedData());

            modelBuilder.Entity<CountryRegion>()
               .HasMany(r => r.Cities)
               .WithOne(s => s.CountryRegion)
               .HasForeignKey(t => t.CountryRegionId);

            modelBuilder.Entity<City>()
               .HasMany(r => r.DistrictOrTowns)
               .WithOne(s => s.City)
               .HasForeignKey(t => t.CityId);

            modelBuilder.Entity<DistrictOrTown>()
              .HasMany(r => r.Barangays)
              .WithOne(s => s.DistrictOrTown)
              .HasForeignKey(t => t.DistrictOrTownId);
        }

        #region DbSets
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryRegion> CountryRegions { get; set; }
        public DbSet<DistrictOrTown> DistrictOrTowns { get; set; }
        public DbSet<Barangay> Barangays { get; set; }
        public DbSet<City> Cities { get; set; }
        #endregion 
    }
}
