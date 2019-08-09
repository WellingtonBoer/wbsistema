using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wbsistema.ApplicationCore.Entity;

namespace wbsistema.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
                return;

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Carcaju Carcara",
                    CPF = "11111111111"

                },

                new Cliente
                {
                    Nome = "Yanni Chrisomallys",
                    CPF = "22222222222"
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "999999999",
                    Email = "emailcontato1@teste.com",
                    Cliente = clientes[0]
                },
                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "888888888",
                    Email = "emailcontato2@teste.com",
                    Cliente = clientes[1]
                }
            };

            context.Contatos.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
