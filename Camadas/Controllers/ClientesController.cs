using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ClientesController
    {

        private static List<Cliente> listaClientes = new List<Cliente>();

        public void Adicionar(string nome, string cpf)
        {
            Cliente c = new Cliente();
            c.Nome = nome;
            c.Cpf = cpf;
        }    
        public Cliente Detalhes (int id)
         {
            foreach (Cliente cli in listaClientes)
            {
                  if (cli.ClienteId == id)
                      return cli;
            }

             return null;

          }

        public void Editar (int id, string nome, string cpf)
         {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ClienteId == id)
                {
                    cli.Nome = nome;
                    cli.Cpf = cpf;
                }
            }

         }

        public void Excluir(int id)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.ClienteId == id)
                    listaClientes.Remove(cli);
            }

        }
    }
}
