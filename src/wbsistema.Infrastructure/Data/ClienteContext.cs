using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using wbsistema.ApplicationCore.Entity;

namespace wbsistema.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");
            modelBuilder.Entity<Menu>().ToTable("Menu");

            #region Configurações Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(p => p.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasMany(p => p.Contatos)
                .WithOne(p => p.Cliente)
                .HasForeignKey(p => p.ClienteId)
                .HasPrincipalKey(p => p.ClienteId);

            modelBuilder.Entity<Cliente>().Property(p => p.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
            #endregion

            #region Configurações Contato

            modelBuilder.Entity<Contato>()
                .HasKey(p => p.ContatoId);

            modelBuilder.Entity<Contato>()
                .HasOne(p => p.Cliente)
                .WithMany(p => p.Contatos)
                .HasForeignKey(p => p.ClienteId)
                .HasPrincipalKey(p => p.ClienteId);

            modelBuilder.Entity<Contato>().Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(p => p.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(p => p.Telefone)
                .HasColumnType("varchar(15)");
            #endregion

            #region Configurações Profissao

            modelBuilder.Entity<Profissao>().Property(p => p.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(p => p.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(p => p.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            #endregion

            #region Configurações Endereco

            modelBuilder.Entity<Endereco>().Property(p => p.Bairro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(p => p.CEP)
                .HasColumnType("varchar(15)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(p => p.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(p => p.Referencia)
                .HasColumnType("varchar(400)");

            #endregion

            #region Configurações ProfissaoCliente

            modelBuilder.Entity<ProfissaoCliente>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(p => p.Cliente)
                .WithMany(p => p.ProfissaoClientes)
                .HasForeignKey(p => p.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
               .HasOne(p => p.Profissao)
               .WithMany(p => p.ProfissaoClientes)
               .HasForeignKey(p => p.ProfissaoId);
            #endregion

            #region Configurações Menu

            modelBuilder.Entity<Menu>().HasKey(p => p.Id);

            modelBuilder.Entity<Menu>()
                .HasMany(p => p.SubMenu)
                .WithOne()
                .HasForeignKey(p => p.MenuId);




            #endregion

        }
    }
}
