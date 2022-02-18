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
    class DALComandosCompras
    {
        public string mensagem = "";

        public string Cadastrar(Compras compras)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                sqlCommand.CommandText = "insert into TB_Gastos values (@idProduto, @descProduto, @qntdProduto, " +
                "@precoProduto, @valorTotal, @data) ; select @@IDENTITY;";

                sqlCommand.Parameters.AddWithValue("@idProduto", compras.IdProduto);
                sqlCommand.Parameters.AddWithValue("@descProduto", compras.DescricaoProduto);
                sqlCommand.Parameters.AddWithValue("@qntdProduto", compras.Quantidade);
                sqlCommand.Parameters.AddWithValue("@precoProduto", compras.Preco);
                sqlCommand.Parameters.AddWithValue("@valorTotal", compras.ValorTotal);
                sqlCommand.Parameters.AddWithValue("@data", compras.DataPagamento);

                sqlCommand.Connection = conexaoBD.Conectar();
                sqlCommand.ExecuteNonQuery();

                AtualizaQuantidadeProduto(compras.Quantidade, compras.IdProduto);
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

        public DataTable ConsultarProduto()
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Produto where St_Produto = 'A'", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }

        private void AtualizaQuantidadeProduto(int quantidade, int idProduto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();

            sqlCommand.CommandText = "update TB_Produto set Qt_Produto = @quantidade where ID_Produto = @idProduto";

            sqlCommand.Parameters.AddWithValue("@quantidade", quantidade);
            sqlCommand.Parameters.AddWithValue("@idProduto", idProduto);

            sqlCommand.Connection = conexaoBD.Conectar();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
        }

        public DataTable Relatorio(DateTime inicio, DateTime fim)
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Gastos where Dt_Compra >= '" + inicio.ToString("d") + "' and " +
                "Dt_Compra <= '" + fim.ToString("d") + "';", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }
    }
}
