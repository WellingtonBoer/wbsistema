using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using wbsistema.ApplicationCore.Entity;

namespace wbsistema.Infrastructure.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contato");


            builder
             .HasKey(p => p.ContatoId);

            builder
                .HasOne(p => p.Cliente)
                .WithMany(p => p.Contatos)
                .HasForeignKey(p => p.ClienteId)
                .HasPrincipalKey(p => p.ClienteId);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Telefone)
                .HasColumnType("varchar(15)");
        }
    }
}
