using System.Data.SqlClient;

namespace ProjetoMaresias.ConexoesBD
{
    class ConexaoBD
    {
        SqlConnection sqlConnection = new SqlConnection();

        public ConexaoBD()
        {
            sqlConnection.ConnectionString = @"Data Source=DESKTOP-IEEC6LA;Initial Catalog=MaresiasBD;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }
        public void Desconectar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
