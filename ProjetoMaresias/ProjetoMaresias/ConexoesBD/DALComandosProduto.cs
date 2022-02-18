using ProjetoMaresias.Enums;
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
    class DALComandosProduto
    {
        public string mensagem = "";

        public string Cadastrar(Produto produto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                sqlCommand.CommandText = "insert into TB_Produto values (@descProduto, @descCategoria, @precoProduto, " +
                "@qntdProduto, @status) ; select @@IDENTITY;";

                sqlCommand.Parameters.AddWithValue("@descProduto", produto.DescricaoProduto);
                sqlCommand.Parameters.AddWithValue("@descCategoria", produto.Categoria.ToString());
                sqlCommand.Parameters.AddWithValue("@precoProduto", produto.Preco);
                sqlCommand.Parameters.AddWithValue("@qntdProduto", produto.Quantidade);
                sqlCommand.Parameters.AddWithValue("@status", produto.Status);

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

        public Produto CarregaDados(int idProduto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Produto produto = new Produto();

            sqlCommand.CommandText = "select * from TB_Produto where ID_Produto = @idProduto";
            sqlCommand.Parameters.AddWithValue("@idProduto", idProduto);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                produto.IdProduto = Convert.ToInt32(dataReader["ID_Produto"]);
                produto.DescricaoProduto = dataReader["Ds_Produto"].ToString();
                produto.Categoria = Enum.Parse<Categoria>(dataReader["Ds_Categoria"].ToString());
                produto.Preco = Convert.ToDouble(dataReader["Vl_Produto"]);
                produto.Quantidade = Convert.ToInt32(dataReader["Qt_Produto"]);
                produto.Status = Convert.ToChar(dataReader["St_Produto"]);
            }
            conexaoBD.Desconectar();
            return produto;
        }

        public string Alterar(Produto produto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                sqlCommand.CommandText = "update TB_Produto set Ds_Produto = @descProduto, Ds_Categoria = @descCategoria, Vl_Produto = " +
                    "@precoProduto, Qt_Produto = @qntdProduto, St_Produto = @status where ID_Produto = @idProduto";

                sqlCommand.Parameters.AddWithValue("@descProduto", produto.DescricaoProduto);
                sqlCommand.Parameters.AddWithValue("@descCategoria", produto.Categoria.ToString());
                sqlCommand.Parameters.AddWithValue("@precoProduto", produto.Preco);
                sqlCommand.Parameters.AddWithValue("@qntdProduto", produto.Quantidade);
                sqlCommand.Parameters.AddWithValue("@status", produto.Status);
                sqlCommand.Parameters.AddWithValue("@idProduto", produto.IdProduto);

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

        public DataTable ConsultarProduto(string descProduto, string status)
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Produto " +
                "where Ds_Produto like '%" + descProduto + "%' and St_Produto like '%" + status + "%'", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }

        public Produto ProcuraProduto(string descricao)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Produto produto = new Produto();

            sqlCommand.CommandText = "select * from TB_Produto where Ds_Produto = @descProduto";
            sqlCommand.Parameters.AddWithValue("@descProduto", descricao);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                produto.IdProduto = Convert.ToInt32(dataReader["ID_Produto"]);
                produto.DescricaoProduto = dataReader["Ds_Produto"].ToString();
                produto.Categoria = Enum.Parse<Categoria>(dataReader["Ds_Categoria"].ToString());
                produto.Preco = Convert.ToDouble(dataReader["Vl_Produto"]);
                produto.Quantidade = Convert.ToInt32(dataReader["Qt_Produto"]);
                produto.Status = Convert.ToChar(dataReader["St_Produto"]);
            }
            conexaoBD.Desconectar();
            return produto;
        }
    }
}
