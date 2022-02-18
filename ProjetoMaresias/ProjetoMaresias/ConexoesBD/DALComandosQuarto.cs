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
    class DALComandosQuarto
    {
        public string mensagem = "";

        private bool verificarCadastro(int numero)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            bool cadastrado = false;
            sqlCommand.CommandText = "select Nr_Quarto from TB_Quarto where Nr_Quarto = @numero";
            sqlCommand.Parameters.AddWithValue("@numero", numero);

            try
            {
                sqlCommand.Connection = conexaoBD.Conectar();
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Close();
                    this.mensagem = "Não foi possível concluir o cadastro. Número de quarto já existe!";
                    return cadastrado = true;
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
            return cadastrado;
        }

        public string Cadastrar(Quarto quarto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                if (!verificarCadastro(quarto.Numero))
                {
                    sqlCommand.CommandText = "insert into TB_Quarto values (@numero, @descricao, @andar, @diaria)";
                    sqlCommand.Parameters.AddWithValue("@numero", quarto.Numero);
                    sqlCommand.Parameters.AddWithValue("@descricao", quarto.Descricao);
                    sqlCommand.Parameters.AddWithValue("@andar", quarto.Andar);
                    sqlCommand.Parameters.AddWithValue("@diaria", quarto.Diaria);
                    sqlCommand.Connection = conexaoBD.Conectar();
                    sqlCommand.ExecuteNonQuery();
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

        public Quarto CarregaDados(int numQuarto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Quarto quarto = new Quarto();

            sqlCommand.CommandText = "select * from TB_Quarto where Nr_Quarto = @numQuarto";
            sqlCommand.Parameters.AddWithValue("@numQuarto", numQuarto);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                quarto.Numero = Convert.ToInt32(dataReader["Nr_Quarto"]);
                quarto.Descricao = dataReader["Ds_Quarto"].ToString();
                quarto.Andar = Convert.ToInt32(dataReader["Nr_Andar"]);
                quarto.Diaria = Convert.ToDouble(dataReader["Vl_Diaria"]);
            }
            conexaoBD.Desconectar();
            return quarto;
        }

        public DataTable Consultar(string descricao)
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Quarto where Ds_Quarto" +
                " like '%" + descricao + "%'", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }

        public string Alterar(Quarto quarto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                sqlCommand.CommandText = "update TB_Quarto set Ds_Quarto = @descricao, Nr_Andar = @andar, " +
                    "Vl_Diaria = @diaria where Nr_Quarto = @numero";
                sqlCommand.Parameters.AddWithValue("@descricao", quarto.Descricao);
                sqlCommand.Parameters.AddWithValue("@andar", quarto.Andar);
                sqlCommand.Parameters.AddWithValue("@diaria", quarto.Diaria);
                sqlCommand.Parameters.AddWithValue("@numero", quarto.Numero);

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

        public DataTable Disponibilidade(DateTime dataEntrada, DateTime dataSaida)
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlCommand sqlCommand = new SqlCommand();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            List<int> listaQuartos = new List<int>();
            DateTime entrada, saida;
            string status;

            sqlCommand.CommandText = "select * from TB_Reserva";

            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    entrada = Convert.ToDateTime(dataReader["Dt_Entrada"]);
                    saida = Convert.ToDateTime(dataReader["Dt_Saida"]);
                    status = dataReader["St_Reserva"].ToString();
                    if (status == "Agendado\t")
                    {
                        if ((dataEntrada == entrada) || (dataEntrada > entrada && dataEntrada < saida) ||
                            (dataSaida > entrada && dataSaida <= saida) || (dataEntrada < entrada && dataSaida > saida))
                        {
                            listaQuartos.Add(Convert.ToInt32(dataReader["Nr_Quarto"]));
                        }
                    }
                }
            }
            dataReader.Close();

            if (listaQuartos.Count != 0)
            {
                sqlCommand.CommandText = "select * from TB_Quarto";
                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(table);

                foreach (int quarto in listaQuartos)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        if(dr.RowState != DataRowState.Deleted)
                        {
                            if (dr["Nr_Quarto"].ToString() == quarto.ToString())
                            {
                                dr.Delete();

                            }
                        }   
                    }
                }
            }
            else
            {
                sqlCommand.CommandText = "select * from TB_Quarto";
                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(table);
            }

            conexaoBD.Desconectar();
            return table;
        }
    }
}
