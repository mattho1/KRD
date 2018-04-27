using ClassLibraryCommon.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryInfrastructure.Configurations;

namespace ClassLibraryInfrastructure.DataAccess
{
    public class CourierApplicationContext : DbContext
    {
        public CourierApplicationContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Package> Packages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PackageConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
