using Hospital.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace Hospital.DataAccess.Configurations
{
    public class DoktorConfiguration : IEntityTypeConfiguration<Doktor> 
    {
        public void Configure(EntityTypeBuilder<Doktor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ime).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Prezime).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Specijalnost).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Jmbg).IsRequired().HasMaxLength(13);

            builder.HasMany(x => x.TipoviPregleda).WithMany(x => x.Doktori);
            

            
        }
    }
}
