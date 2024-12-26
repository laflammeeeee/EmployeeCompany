using EmployeeCompany.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EmployeeCompany.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Employee Entity
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
                entity.Property(e => e.LastName).HasMaxLength(200).IsRequired();
                entity.Property(e => e.Address).HasMaxLength(300).IsRequired();
            });

            // Configure Company Entity
            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(c => c.Name).IsRequired();
                entity.Property(c => c.Address).IsRequired();
                entity.Property(c => c.Owner).IsRequired();
            });
        }
    }
}
