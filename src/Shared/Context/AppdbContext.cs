using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examenliga_c.src.modules.Torneos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace examenliga_c.src.Shared.Context
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options)
        {
        }

        public AppdbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Torneo> Torneos => Set<Torneo>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppdbContext).Assembly);
        }
    }
}