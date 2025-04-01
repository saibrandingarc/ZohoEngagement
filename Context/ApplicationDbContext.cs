using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using ZohoEngagement.Models;

namespace ZohoEngagement.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSets for your entities
        public DbSet<Settings> Settings { get; set; }
        public DbSet<ClientDetail> ClientDetails { get; set; }
        public DbSet<ZohoCasesMonth> ZohoCasesMonths { get; set; }
        public DbSet<ZohoDeliverablesMonth> ZohoDeliverablesMonths { get; set; }
        public DbSet<ZohoFutureDeliverables> ZohoFutureDeliverabless { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity properties and relationships here
        }
    }
}

