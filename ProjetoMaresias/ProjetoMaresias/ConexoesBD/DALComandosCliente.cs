using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoMaresias.Modelo;

namespace ProjetoMaresias.ConexoesBD
{
    class DALComandosCliente
    {
        public string mensagem = "";
        
        private bool verificarCadastro(string cpf)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            bool cadastrado = false;
            sqlCommand.CommandText = "select Nr_CPF from TB_Cliente where Nr_CPF = @cpf";
            sqlCommand.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                sqlCommand.Connection = conexaoBD.Conectar();
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Close();
                    this.mensagem = "Não foi possível concluir o cadastro. CPF já cadastrado!";
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

        public string Cadastrar(Cliente cliente)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                if (!verificarCadastro(cliente.Cpf))
                {
                    sqlCommand.CommandText = "insert into TB_Cliente values (@nome, @celular, @rg, @cpf, @email)";
                    sqlCommand.Parameters.AddWithValue("@nome", cliente.Nome);
                    sqlCommand.Parameters.AddWithValue("@celular", cliente.Celular);
                    sqlCommand.Parameters.AddWithValue("@rg", cliente.Rg);
                    sqlCommand.Parameters.AddWithValue("@cpf", cliente.Cpf);
                    sqlCommand.Parameters.AddWithValue("@email", cliente.Email);
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

        public Cliente CarregaDados(int codCliente)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Cliente cliente = new Cliente();

            sqlCommand.CommandText = "select * from TB_Cliente where ID_Cliente = @codCliente";
            sqlCommand.Parameters.AddWithValue("@codCliente", codCliente);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                cliente.IdCliente = Convert.ToInt32(dataReader["ID_Cliente"]);
                cliente.Nome = dataReader["Nm_Cliente"].ToString();
                cliente.Celular = dataReader["Nr_Celular"].ToString();
                cliente.Rg = dataReader["Nr_RG"].ToString();
                cliente.Cpf = dataReader["Nr_CPF"].ToString();
                cliente.Email = dataReader["Ds_Email"].ToString();
            }
            conexaoBD.Desconectar();
            return cliente;
        }

        public DataTable Consultar(string nome, string cpf)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Cliente where Nm_Cliente" +
                " like '%" + nome + "%' and Nr_CPF like '%" + cpf + "%'", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }

        public string Alterar(Cliente cliente)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                sqlCommand.CommandText = "update TB_Cliente set Nm_Cliente = @nome, Nr_Celular = @celular, Nr_RG = @rg, " +
                    "Nr_CPF = @cpf, Ds_Email = @email where ID_Cliente = @codCliente";
                sqlCommand.Parameters.AddWithValue("@nome", cliente.Nome);
                sqlCommand.Parameters.AddWithValue("@celular", cliente.Celular);
                sqlCommand.Parameters.AddWithValue("@rg", cliente.Rg);
                sqlCommand.Parameters.AddWithValue("@cpf", cliente.Cpf);
                sqlCommand.Parameters.AddWithValue("@email", cliente.Email);
                sqlCommand.Parameters.AddWithValue("@codCliente", cliente.IdCliente);

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
    }
}
