using ProjetoMaresias.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaresias.ConexoesBD
{
    class DALComandosHospedagem
    {
        public string mensagem = "";

        private bool verificarReserva(int numReserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            bool cadastrado = false;
            string status;
            sqlCommand.CommandText = "select * from TB_Reserva where Nr_Reserva = @numReserva";
            sqlCommand.Parameters.AddWithValue("@numReserva", numReserva);

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

        private bool verificarHospedagem(int numReserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            bool cadastrado = false;
            sqlCommand.CommandText = "select * from TB_Hospedagem where Nr_Reserva = @numReserva";
            sqlCommand.Parameters.AddWithValue("@numReserva", numReserva);

            sqlCommand.Connection = conexaoBD.Conectar();
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                cadastrado = true;
                dataReader.Close();
            }
            conexaoBD.Desconectar();
            return cadastrado;
        }

        private void finalizaReserva(int numReserva, string status)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();

            sqlCommand.CommandText = "update TB_Reserva set St_Reserva = @status where Nr_Reserva = @numReserva";
            sqlCommand.Parameters.AddWithValue("@status", status);
            sqlCommand.Parameters.AddWithValue("@numReserva", numReserva);
            sqlCommand.Connection = conexaoBD.Conectar();
            sqlCommand.ExecuteNonQuery();
            conexaoBD.Desconectar();
        }

        private int procuraQuarto(int numReserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            int numQuarto = 0;

            sqlCommand.CommandText = "select Nr_Quarto from TB_Reserva where Nr_Reserva = @numReserva";
            sqlCommand.Parameters.AddWithValue("@numReserva", numReserva);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                numQuarto = Convert.ToInt32(dataReader["Nr_Quarto"]);
            }
            conexaoBD.Desconectar();
            return numQuarto;
        }

        public string Checkin(Hospedagem hospedagem)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                if (!verificarHospedagem(hospedagem.NumeroReserva))
                {
                    if (verificarReserva(hospedagem.NumeroReserva))
                    {
                        sqlCommand.CommandText = "insert into TB_Hospedagem values (@idCliente, @nomeCliente, @numReserva, @diasEstadia, " +
                    "@idProduto, @descProduto, @valorProduto, @qntdConsumo, @valorHospedagem, @qntdAcompanhante, @horaCheckin," +
                    " @horaCheckout, @dataCheckout, @status); select @@IDENTITY;";
                        sqlCommand.Parameters.AddWithValue("@idCliente", hospedagem.IdCliente);
                        sqlCommand.Parameters.AddWithValue("@nomeCliente", hospedagem.NomeCliente);
                        sqlCommand.Parameters.AddWithValue("@numReserva", hospedagem.NumeroReserva);
                        sqlCommand.Parameters.AddWithValue("@diasEstadia", hospedagem.DiasEstadia);
                        sqlCommand.Parameters.AddWithValue("@idProduto", DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@descProduto", DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@valorProduto", DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@qntdConsumo", DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@valorHospedagem", hospedagem.ValorHospedagem);
                        sqlCommand.Parameters.AddWithValue("@qntdAcompanhante", hospedagem.QuantidadeAcompanhante);
                        sqlCommand.Parameters.AddWithValue("@horaCheckin", hospedagem.Checkin);
                        sqlCommand.Parameters.AddWithValue("@horaCheckout", hospedagem.Checkout);
                        sqlCommand.Parameters.AddWithValue("@dataCheckout", DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@status", hospedagem.Status);

                        sqlCommand.Connection = conexaoBD.Conectar();
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        this.mensagem = "Não foi possível concluir o cadastro. Número de reserva não cadastrado!";
                    } 
                }
                else
                {
                    this.mensagem = "Não foi possível concluir o cadastro. Este número de reserva já realizou o check-in!";
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

        public Hospedagem CarregaDados(int codReserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Hospedagem hospedagem = new Hospedagem();

            sqlCommand.CommandText = "select * from TB_Hospedagem where Nr_Reserva = @codReserva";
            sqlCommand.Parameters.AddWithValue("@codReserva", codReserva);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                hospedagem.IdCliente = Convert.ToInt32(dataReader["ID_Cliente"]);
                hospedagem.NomeCliente = dataReader["Nm_Cliente"].ToString();
                hospedagem.NumeroReserva = Convert.ToInt32(dataReader["Nr_Reserva"]);
                hospedagem.DiasEstadia = Convert.ToInt32(dataReader["Nr_DiasEstadia"]);
                hospedagem.QuantidadeAcompanhante = Convert.ToInt32(dataReader["Nr_Acompanhantes"]);
                hospedagem.Checkin = TimeSpan.Parse(dataReader["Hr_Checkin"].ToString());
                hospedagem.Checkout = TimeSpan.Parse(dataReader["Hr_Checkout"].ToString());
                hospedagem.Status = dataReader["St_Hospedagem"].ToString();
                hospedagem.ValorHospedagem = Convert.ToInt32(dataReader["Vl_Hospedagem"]);

                while (dataReader.Read())
                {
                    hospedagem.ValorHospedagem = Convert.ToInt32(dataReader["Vl_Hospedagem"]);
                }

            }
            dataReader.Close();
            conexaoBD.Desconectar();
            return hospedagem;
        }

        public DataTable Faturamento(DateTime inicio, DateTime fim)
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Hospedagem where Dt_Checkout >= '" + inicio.ToString("d") + "' and " +
                "Dt_Checkout <= '" + fim.ToString("d") + "' and St_Hospedagem = 'Finalizado' ;", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }

        public string Checkout(Hospedagem hospedagem)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                sqlCommand.CommandText = "update TB_Hospedagem set Hr_Checkout = @horaCheckout, " +
                    "Dt_Checkout = @dataCheckout, St_Hospedagem = @status where Nr_Reserva = @numReserva";

                sqlCommand.Parameters.AddWithValue("@horaCheckout", hospedagem.Checkout);
                sqlCommand.Parameters.AddWithValue("@dataCheckout", DateTime.Now.ToString("yyyy/MM/dd"));
                sqlCommand.Parameters.AddWithValue("@status", hospedagem.Status);
                sqlCommand.Parameters.AddWithValue("@numReserva", hospedagem.NumeroReserva);

                sqlCommand.Connection = conexaoBD.Conectar();
                sqlCommand.ExecuteNonQuery();
                finalizaReserva(hospedagem.NumeroReserva, hospedagem.Status);
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

        public DataTable ConsultarConsumo(int numReserva)
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select ID_Produto, Ds_Produto, Vl_produto, Qt_Consumo, Vl_Hospedagem from TB_Hospedagem " +
                "where Nr_Reserva like '%" + numReserva + "%'", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }

        public Hospedagem DadosCadastro(int numReserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Hospedagem hospedagem = new Hospedagem();

            sqlCommand.CommandText = "select * from TB_Reserva where Nr_Reserva = @numReserva";
            sqlCommand.Parameters.AddWithValue("@numReserva", numReserva);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                hospedagem.IdCliente = Convert.ToInt32(dataReader["ID_Cliente"]);
                hospedagem.NomeCliente = dataReader["Nm_Cliente"].ToString();
                DateTime entrada = Convert.ToDateTime(dataReader["Dt_Entrada"]);
                DateTime saida = Convert.ToDateTime(dataReader["Dt_Saida"]);
                hospedagem.DiasEstadia = (saida - entrada).Days;
                dataReader.Close();

                sqlCommand.CommandText = "select * from TB_Quarto where Nr_Quarto = @numQuarto";
                sqlCommand.Parameters.AddWithValue("@numQuarto", procuraQuarto(numReserva));
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    double precoDiaria = Convert.ToDouble(dataReader["Vl_Diaria"]);
                    hospedagem.ValorHospedagem = precoDiaria * hospedagem.DiasEstadia;
                }
                conexaoBD.Desconectar();
                hospedagem.NumeroReserva = numReserva;
            }
            else
            {
                hospedagem.NumeroReserva = 0;
            }
            return hospedagem;
        }

        private int primeiroConsumo(int numReserva)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            int idProduto = 0;
            sqlCommand.CommandText = "select * from TB_Hospedagem where Nr_Reserva = @numReserva";
            sqlCommand.Parameters.AddWithValue("@numReserva", numReserva);

            sqlCommand.Connection = conexaoBD.Conectar();
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                if ((dataReader["ID_Produto"]) == DBNull.Value)
                {
                    idProduto = 0;
                }
                else
                {
                    idProduto = Convert.ToInt32(dataReader["ID_Produto"]);
                }
                dataReader.Close();
            }
            conexaoBD.Desconectar();
            return idProduto;
        }

        public string IncluirConsumo(Hospedagem hospedagem)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                if (alteraQntdConsumo(hospedagem.QuantidadeConsumo, hospedagem.IdProduto))
                {
                    if (primeiroConsumo(hospedagem.NumeroReserva) == 0)
                    {
                        sqlCommand.CommandText = "update TB_Hospedagem set ID_Produto = @idProduto, Ds_Produto = @descProduto, Vl_Produto = " +
                            "@valorProduto, Qt_Consumo = @qntdConsumo, Vl_Hospedagem = @valorHospedagem";
                        sqlCommand.Parameters.AddWithValue("@idProduto", hospedagem.IdProduto);
                        sqlCommand.Parameters.AddWithValue("@descProduto", hospedagem.DescricaoProduto);
                        sqlCommand.Parameters.AddWithValue("@valorProduto", hospedagem.ValorProduto);
                        sqlCommand.Parameters.AddWithValue("@qntdConsumo", hospedagem.QuantidadeConsumo);
                        sqlCommand.Parameters.AddWithValue("@valorHospedagem", hospedagem.ValorHospedagem);

                        sqlCommand.Connection = conexaoBD.Conectar();
                        sqlCommand.ExecuteNonQuery();
                        conexaoBD.Desconectar();
                    }
                    else
                    {
                        Hospedagem dadosHospedagem = new Hospedagem();
                        dadosHospedagem = CarregaDados(hospedagem.NumeroReserva);
                        hospedagem.IdCliente = dadosHospedagem.IdCliente;
                        hospedagem.NomeCliente = dadosHospedagem.NomeCliente;
                        hospedagem.DiasEstadia = dadosHospedagem.DiasEstadia;
                        hospedagem.QuantidadeAcompanhante = dadosHospedagem.QuantidadeAcompanhante;
                        hospedagem.Checkin = dadosHospedagem.Checkin;
                        hospedagem.Checkout = dadosHospedagem.Checkout;
                        hospedagem.Status = dadosHospedagem.Status;

                        sqlCommand.CommandText = "insert into TB_Hospedagem values (@idCliente, @nomeCliente, @numReserva, @diasEstadia, " +
                            "@idProduto, @descProduto, @valorProduto, @qntdConsumo, @valorHospedagem, @qntdAcompanhante," +
                            " @horaCheckin, @horaCheckout, @dataCheckout, @status); select @@IDENTITY;";

                        sqlCommand.Parameters.AddWithValue("@idCliente", hospedagem.IdCliente);
                        sqlCommand.Parameters.AddWithValue("@nomeCliente", hospedagem.NomeCliente);
                        sqlCommand.Parameters.AddWithValue("@numReserva", hospedagem.NumeroReserva);
                        sqlCommand.Parameters.AddWithValue("@diasEstadia", hospedagem.DiasEstadia);
                        sqlCommand.Parameters.AddWithValue("@idProduto", hospedagem.IdProduto);
                        sqlCommand.Parameters.AddWithValue("@descProduto", hospedagem.DescricaoProduto);
                        sqlCommand.Parameters.AddWithValue("@valorProduto", hospedagem.ValorProduto);
                        sqlCommand.Parameters.AddWithValue("@qntdConsumo", hospedagem.QuantidadeConsumo);
                        sqlCommand.Parameters.AddWithValue("@valorHospedagem", hospedagem.ValorHospedagem);
                        sqlCommand.Parameters.AddWithValue("@qntdAcompanhante", hospedagem.QuantidadeAcompanhante);
                        sqlCommand.Parameters.AddWithValue("@horaCheckin", hospedagem.Checkin);
                        sqlCommand.Parameters.AddWithValue("@horaCheckout", hospedagem.Checkout);
                        sqlCommand.Parameters.AddWithValue("@dataCheckout", DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@status", hospedagem.Status);

                        sqlCommand.Connection = conexaoBD.Conectar();
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.mensagem = "O produto está sem estoque!";
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

        private bool alteraQntdConsumo(int qntdProduto, int idProduto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            bool temEstoque = false;

            sqlCommand.CommandText = "select * from TB_Produto where ID_Produto = @idProduto";
            sqlCommand.Parameters.AddWithValue("@idProduto", idProduto);

            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                int quantidade = Convert.ToInt32(dataReader["Qt_Produto"]);
                qntdProduto = quantidade - qntdProduto;
                dataReader.Close();
                if (qntdProduto >= 0)
                {
                    sqlCommand.CommandText = "update TB_Produto set Qt_Produto = @qntdProduto where ID_Produto = @idProduto";
                    sqlCommand.Parameters.AddWithValue("@qntdProduto", qntdProduto);
                    sqlCommand.ExecuteNonQuery();
                    temEstoque = true;
                }
            }
            conexaoBD.Desconectar();
            return temEstoque;
        }

        public DataTable ProdutosDisponiveis()
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Produto where Ds_Categoria = 'Consumivel' and " +
                "St_Produto = 'A'", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }
    }
}
