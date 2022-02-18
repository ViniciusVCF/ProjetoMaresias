using ProjetoMaresias.ConexoesBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaresias.Modelo
{
    class Hospedagem
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public int NumeroReserva { get; set; }
        public int DiasEstadia { get; set; }
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public double ValorProduto { get; set; }
        public int QuantidadeConsumo { get; set; }
        public double ValorHospedagem { get; set; }
        public int QuantidadeAcompanhante { get; set; }
        public TimeSpan Checkin { get; set; }
        public TimeSpan Checkout { get; set; }
        public string Status { get; set; }

        public Hospedagem()
        {
        }

        public string CadastroCheckin(Hospedagem hospedagem) //Método que chama o comando de input da hospedagem no banco de dados.
        {
            DALComandosHospedagem comandosHospedagem = new DALComandosHospedagem();
            return comandosHospedagem.Checkin(hospedagem);
        }

        public Hospedagem CarregarDados(int codReserva)  //Método que chama a coleta dos dados da hospedagem através do código no banco de dados.
        {
            DALComandosHospedagem comandosHospedagem = new DALComandosHospedagem();
            return comandosHospedagem.CarregaDados(codReserva);
        }

        public string CadastroCheckout(Hospedagem hospedagem) //Método que chama o comando de update da hospedagem no banco de dados.
        {
            DALComandosHospedagem comandosHospedagem = new DALComandosHospedagem();
            return comandosHospedagem.Checkout(hospedagem);
        }

        public DataTable ConsultaConsumo(int numReserva) //Método que trás todos os consumos do cliente através da tabela no banco de dados.
        {
            DALComandosHospedagem comandosHospedagem = new DALComandosHospedagem();
            return comandosHospedagem.ConsultarConsumo(numReserva);
        }

        public string IncluiConsumo(Hospedagem hospedagem) //Método que trás todos os consumos do cliente através da tabela no banco de dados.
        {
            DALComandosHospedagem comandosHospedagem = new DALComandosHospedagem();
            return comandosHospedagem.IncluirConsumo(hospedagem);
        }

        public Hospedagem DadosCadastro(int numReserva) //Método que pega informações para preenchimento automático de campos do checkin no banco de dados.
        {
            DALComandosHospedagem comandosHospedagem = new DALComandosHospedagem();
            return comandosHospedagem.DadosCadastro(numReserva);
        }
    
        public DataTable ProdutosDisponiveis()
        {
            DALComandosHospedagem comandosHospedagem = new DALComandosHospedagem();
            return comandosHospedagem.ProdutosDisponiveis();
        }

        public DataTable Faturamento(DateTime inicio, DateTime fim)
        {
            DALComandosHospedagem comandosHospedagem = new DALComandosHospedagem();
            return comandosHospedagem.Faturamento(inicio, fim);
        }
    }
}
