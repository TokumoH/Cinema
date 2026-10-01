using CinemaDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CinemaRepository.Mapping
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Melancia");
            //builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome)
                //.HasColumnName("NomeDoGenero")
                .IsRequired(true)
                .HasMaxLength(50);
        }
    }
}
