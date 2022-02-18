using ProjetoMaresias.ConexoesBD;
using System;
using System.Data;

namespace ProjetoMaresias.Modelo
{
    class Reserva
    {
        public int CodReserva { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public int NumeroQuarto { get; set; }
        public string DescricaoQuarto { get; set; }
        public string Status { get; set; }
        
        public Reserva()
        {
        }

        public string Cadastrar(Reserva reserva) //Método que chama o comando de input da reserva no banco de dados.
        {
            DALComandosReserva comandosReserva = new DALComandosReserva();
            return comandosReserva.Cadastrar(reserva);
        }

        public Reserva CarregarDados(int codReserva)  //Método que chama a coleta dos dados da reserva através do código no banco de dados.
        {
            DALComandosReserva comandosReserva = new DALComandosReserva();
            return comandosReserva.CarregaDados(codReserva);
        }

        public string Alterar(Reserva reserva) //Método que chama o comando de update da reserva no banco de dados.
        {
            DALComandosReserva comandosReserva = new DALComandosReserva();
            return comandosReserva.Alterar(reserva);
        }

        public DataTable Consultar(string nomeCliente, string status) //Método que trás todos os dados da tabela no banco de dados.
        {
            DALComandosReserva comandosReserva = new DALComandosReserva();
            if (status == "Todos")
            {
                status = "";
            }
            return comandosReserva.Consultar(nomeCliente, status);
        }
    
        public Reserva DadosCadastro(string nomeCliente, int numQuarto)
        {
            DALComandosReserva comandosReserva = new DALComandosReserva();

            return comandosReserva.DadosCadastro(nomeCliente, numQuarto);
        }
    }
}
