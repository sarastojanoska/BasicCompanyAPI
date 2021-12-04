using BasicCompanyWebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Data
{
    public class BasicCompanyDbContext : DbContext
    {
        public BasicCompanyDbContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>()
                .HasMany<Contact>(c => c.Contacts)
                .WithOne(co => co.Country)
                .HasForeignKey(co => co.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Company>()
                .HasMany<Contact>(c => c.Contacts)
                .WithOne(co => co.Company)
                .HasForeignKey(co => co.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
