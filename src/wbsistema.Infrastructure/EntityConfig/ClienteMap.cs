using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using wbsistema.ApplicationCore.Entity;

namespace wbsistema.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)

        {
            builder.ToTable("Cliente");

            builder
               .HasKey(p => p.ClienteId);

            builder
                .HasOne(p => p.Endereco)
                .WithOne(p => p.Cliente)
                .HasForeignKey<Endereco>(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Contatos)
                .WithOne(p => p.Cliente)
                .HasForeignKey(p => p.ClienteId)
                .HasPrincipalKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

        }
    }
}
