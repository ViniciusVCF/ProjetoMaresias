using ProjetoMaresias.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoMaresias.ConexoesBD
{
    class DALComandosReserva
    {
        public string mensagem = "";

        private bool verificarReserva(int cliente, DateTime dataEntrada)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            bool cadastrado = false;
            string status;
            sqlCommand.CommandText = "select * from TB_Reserva where ID_Cliente = @cliente and " +
                "Dt_Entrada = @dataEntrada";
            sqlCommand.Parameters.AddWithValue("@cliente", cliente);
            sqlCommand.Parameters.AddWithValue("@dataEntrada", dataEntrada);

            sqlCommand.Connection = conexaoBD.Conectar();
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                status = dataReader["St_Reserva"].ToString();
                if (status == "Agendado\t")
                {
                    cadastrado = true;
                }
                dataReader.Close();
            }
            conexaoBD.Desconectar();
            return cadastrado;
        }

        private bool verificarQuarto(int numQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            DateTime entrada, saida;
            string status;
            bool resposta = true;

            sqlCommand.CommandText = "select * from TB_Reserva where Nr_Quarto = @numQuarto";
            sqlCommand.Parameters.AddWithValue("@numQuarto", numQuarto);
            sqlCommand.Connection = conexaoBD.Conectar();
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    entrada = Convert.ToDateTime(dataReader["Dt_Entrada"]);
                    saida = Convert.ToDateTime(dataReader["Dt_Saida"]);
                    status = dataReader["St_Reserva"].ToString();
                    if (status == "Agendado\t")
                    {
                        if ((dataEntrada == entrada )|| (dataEntrada > entrada && dataEntrada < saida) ||
                            (dataSaida > entrada && dataSaida <= saida) || (dataEntrada < entrada && dataSaida > saida))
                        {
                            resposta = false;
                            break;
                        }
                    }
                }
            }
            dataReader.Close();
            conexaoBD.Desconectar();
            return resposta;
        }

        public string Cadastrar(Reserva reserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                if (!verificarReserva(reserva.IdCliente, reserva.DataEntrada))
                {
                    if (verificarQuarto(reserva.NumeroQuarto, reserva.DataEntrada, reserva.DataSaida))
                    {
                        sqlCommand.CommandText = "insert into TB_Reserva values (@cliente, @nomeCliente, @dataEntrada, @dataSaida, " +
                        "@numeroQuarto, @descricaoQuarto, @status) ; select @@IDENTITY;";
                        sqlCommand.Parameters.AddWithValue("@cliente", reserva.IdCliente);
                        sqlCommand.Parameters.AddWithValue("@nomeCliente", reserva.NomeCliente);
                        sqlCommand.Parameters.AddWithValue("@dataEntrada", reserva.DataEntrada);
                        sqlCommand.Parameters.AddWithValue("@dataSaida", reserva.DataSaida);
                        sqlCommand.Parameters.AddWithValue("@numeroQuarto", reserva.NumeroQuarto);
                        sqlCommand.Parameters.AddWithValue("@descricaoQuarto", reserva.DescricaoQuarto);
                        sqlCommand.Parameters.AddWithValue("@status", reserva.Status);
                        sqlCommand.Connection = conexaoBD.Conectar();
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        this.mensagem = "Não foi possível concluir o cadastro. Quarto indisponível ou inexistente!";
                    }
                }
                else
                {
                    this.mensagem = "Não foi possível concluir o cadastro. Reserva já cadastrada!";
                }
            }
            catch (SqlException error)
            {
                this.mensagem = error.Message;
            }
            finally
            {
                conexaoBD.Desconectar();
            }

            return mensagem;
        }

        public Reserva CarregaDados(int codReserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Reserva reserva = new Reserva();

            sqlCommand.CommandText = "select * from TB_Reserva where Nr_Reserva = @codReserva";
            sqlCommand.Parameters.AddWithValue("@codReserva", codReserva);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                reserva.CodReserva = Convert.ToInt32(dataReader["Nr_Reserva"]);
                reserva.IdCliente = Convert.ToInt32(dataReader["ID_CLiente"]);
                reserva.NomeCliente = dataReader["Nm_Cliente"].ToString();
                reserva.DataEntrada = Convert.ToDateTime(dataReader["Dt_Entrada"]);
                reserva.DataSaida = Convert.ToDateTime(dataReader["Dt_Saida"]);
                reserva.NumeroQuarto = Convert.ToInt32(dataReader["Nr_Quarto"]);
                reserva.DescricaoQuarto = dataReader["Ds_Quarto"].ToString();
                reserva.Status = dataReader["St_Reserva"].ToString();
            }
            conexaoBD.Desconectar();
            return reserva;
        }

        public string Alterar(Reserva reserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                sqlCommand.CommandText = "update TB_Reserva set ID_Cliente = @idCliente, Nm_Cliente = @nomeCliente, " +
                    "Dt_Entrada = @entrada, Dt_Saida = @saida, Nr_Quarto = @numQuarto, Ds_Quarto = @descQuarto, " +
                    "St_Reserva = @status where Nr_Reserva = @codReserva";
                sqlCommand.Parameters.AddWithValue("@idCliente", reserva.IdCliente);
                sqlCommand.Parameters.AddWithValue("@nomeCliente", reserva.NomeCliente);
                sqlCommand.Parameters.AddWithValue("@entrada", reserva.DataEntrada);
                sqlCommand.Parameters.AddWithValue("@saida", reserva.DataSaida);
                sqlCommand.Parameters.AddWithValue("@numQuarto", reserva.NumeroQuarto);
                sqlCommand.Parameters.AddWithValue("@descQuarto", reserva.DescricaoQuarto);
                sqlCommand.Parameters.AddWithValue("@status", reserva.Status);
                sqlCommand.Parameters.AddWithValue("@codReserva", reserva.CodReserva);

                sqlCommand.Connection = conexaoBD.Conectar();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                this.mensagem = error.Message;
            }
            finally
            {
                conexaoBD.Desconectar();
            }
            return mensagem;
        }

        public DataTable Consultar(string nomeCliente, string status)
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Reserva where Nm_Cliente like '%" + nomeCliente + "%' and " +
                "St_Reserva like '%" + status + "%';", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }

        public Reserva DadosCadastro(string nomeCliente, int numQuarto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Reserva reserva = new Reserva();

            sqlCommand.CommandText = "select ID_Cliente from TB_Cliente where Nm_Cliente = '" + nomeCliente +"'";
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                reserva.IdCliente = Convert.ToInt32(dataReader["ID_Cliente"]);
            }
            dataReader.Close();
            sqlCommand.CommandText = "select Ds_Quarto from TB_Quarto where Nr_Quarto = @numQuarto";
            sqlCommand.Parameters.AddWithValue("@numQuarto", numQuarto);
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                reserva.DescricaoQuarto = dataReader["Ds_Quarto"].ToString();
            }
            conexaoBD.Desconectar();

            return reserva;
        }
    }
}
