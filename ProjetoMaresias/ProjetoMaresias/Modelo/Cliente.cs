using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMaresias.ConexoesBD;

namespace ProjetoMaresias.Modelo
{
    class Cliente : Pessoa
    {
        public int IdCliente { get; set; }

        public Cliente()
        {
        }

        public string Cadastrar(Cliente cliente)
        {
            DALComandosCliente comandosCliente = new DALComandosCliente();
            comandosCliente.Cadastrar(cliente);

            return comandosCliente.mensagem;
        }

        public DataTable Consultar(string nome, string cpf)
        {
            DALComandosCliente comandosCliente = new DALComandosCliente();
            return comandosCliente.Consultar(nome, cpf);
        }

        public Cliente CarregaDados(int codCliente)
        {
            DALComandosCliente comandosCliente = new DALComandosCliente();
            return comandosCliente.CarregaDados(codCliente);
        }

        public string AlterarDados(Cliente cliente)
        {
            DALComandosCliente comandosCliente = new DALComandosCliente();
            return comandosCliente.Alterar(cliente);
        }
    }
}
