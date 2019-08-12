using System;
using System.Collections.Generic;
using System.Text;

namespace wbsistema.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }
        public ICollection<Contato> Contatos { get; set; }
        public ICollection<ProfissaoCliente> ProfissaoClientes { get; set; }
        public Endereco Endereco { get; set; }
    }
}
