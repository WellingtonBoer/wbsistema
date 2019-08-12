using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using wbsistema.ApplicationCore.Entity;

namespace wbsistema.Infrastructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.ToTable("Profissao");


            builder.Property(p => p.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();

            builder.Property(p => p.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();

        }
    }
}
