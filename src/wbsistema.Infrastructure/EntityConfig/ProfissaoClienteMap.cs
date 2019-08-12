using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using wbsistema.ApplicationCore.Entity;

namespace wbsistema.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder.ToTable("ProfissaoCliente");


            builder
               .HasKey(p => p.Id);

            builder
                .HasOne(p => p.Cliente)
                .WithMany(p => p.ProfissaoClientes)
                .HasForeignKey(p => p.ClienteId);

            builder
               .HasOne(p => p.Profissao)
               .WithMany(p => p.ProfissaoClientes)
               .HasForeignKey(p => p.ProfissaoId);
        }
    }
}
