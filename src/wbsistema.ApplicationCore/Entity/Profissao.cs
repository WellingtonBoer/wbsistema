﻿using System;
using System.Collections.Generic;
using System.Text;

namespace wbsistema.ApplicationCore.Entity
{
    public class Profissao
    {
        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CBO { get; set; }
        public ICollection<ProfissaoCliente> ProfissaoClientes { get; set; }

    }
}
