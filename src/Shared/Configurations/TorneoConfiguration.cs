using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using examenliga_c.src.modules.Torneos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace examenliga_c.src.Shared.Configurations
{
    public class TorneoConfiguration : IEntityTypeConfiguration<Torneo>
    {
        public void Configure(EntityTypeBuilder<Torneo> builder)
        {
            builder.ToTable("Torneo");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(t => t.Tipo)
               .IsRequired()
               .HasMaxLength(100);
            
    }
    }
}