using ProjetoMaresias.Login;
using System.Data.SqlClient;

namespace ProjetoMaresias.ConexoesBD
{
    class DALComandosUsuario
    {
        public Usuario DadosUsuario(int matricula)
        {
            Usuario user = new Usuario();
            DALComandosUsuario comandosUsuario = new DALComandosUsuario();
            SqlDataReader dataReader;

            user.Matricula = matricula;

            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexao = new ConexaoBD();

            sqlCommand.CommandText = "select TB_Funcionario.Nm_Funcionario, TB_LoginFuncionario.Ds_Usuario, TB_LoginFuncionario.Ds_Senha " +
                "from TB_Funcionario inner join TB_LoginFuncionario on TB_Funcionario.Nr_Matricula = TB_LoginFuncionario.Nr_Matricula " +
                "where TB_LoginFuncionario.Nr_Matricula = @matricula";
            sqlCommand.Parameters.AddWithValue("@matricula", user.Matricula);

            sqlCommand.Connection = conexao.Conectar();
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                user.Nome = dataReader["Nm_Funcionario"].ToString();
                user.Username = dataReader["Ds_Usuario"].ToString();
                user.Senha = dataReader["Ds_Senha"].ToString();
            }
            dataReader.Close();
            conexao.Desconectar();
            return user;
        }

        public void AlterarSenha(int matricula, string senha)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexao = new ConexaoBD();

            sqlCommand.CommandText = "update TB_LoginFuncionario set Ds_Senha = @senha where Nr_Matricula = @matricula";
            sqlCommand.Parameters.AddWithValue("@senha", senha);
            sqlCommand.Parameters.AddWithValue("@matricula", matricula);

            sqlCommand.Connection = conexao.Conectar();
            sqlCommand.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
