﻿using System;
using System.Collections.Generic;
using System.Text;

namespace wbsistema.ApplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteID { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }
    }
}
