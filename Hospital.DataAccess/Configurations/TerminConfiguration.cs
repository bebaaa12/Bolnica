using Hospital.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.DataAccess.Configurations
{
    public class TerminConfiguration : IEntityTypeConfiguration<Termin>
    {
        public void Configure(EntityTypeBuilder<Termin> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Datum).IsRequired();
            builder.Property(x => x.VremePocetka).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Datum).IsRequired();

            builder.HasOne(x => x.Raspored)
               .WithMany(x => x.Termini)
               .HasForeignKey(x => x.RasporedId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.ZakazivanjePregleda)
               .WithOne(x => x.Termin).HasForeignKey<ZakazivanjePregleda>(x => x.TerminId);
            
               
        }
    }
}
