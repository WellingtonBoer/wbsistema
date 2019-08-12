using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using wbsistema.ApplicationCore.Entity;

namespace wbsistema.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.Property(p => p.Bairro)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(p => p.CEP)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.Property(p => p.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Referencia)
                .HasColumnType("varchar(400)");
        }
    }
}
