using System;
using System.Data.SqlClient;

namespace ProjetoMaresias.ConexoesBD
{
    class DALComandosLogin
    {
        public string mensagem = "";
        
        public bool VerificarLogin(string login, string senha)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            bool encontrado = false;
            sqlCommand.CommandText = "select * from TB_LoginFuncionario where Ds_Usuario collate Latin1_General_CS_AS = @login and Ds_Senha collate Latin1_General_CS_AS = @senha";
            sqlCommand.Parameters.AddWithValue("@login", login);
            sqlCommand.Parameters.AddWithValue("@senha", senha);

            try
            {
                sqlCommand.Connection = conexaoBD.Conectar();
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    if(Convert.ToChar(dataReader["St_Ativo"]) == 'A')
                    {
                        encontrado = true;
                    }
                }
                dataReader.Close();
            }
            catch (SqlException error)
            {
                this.mensagem = error.Message;
            }
            finally
            {
                conexaoBD.Desconectar();
            }
            return encontrado;
        }

        public bool VerificarCadastro(int matricula)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            bool loginExistente = false;
            try
            {
                sqlCommand.CommandText = "select Nr_Matricula from TB_LoginFuncionario where Nr_Matricula = @matricula";
                sqlCommand.Parameters.AddWithValue("@matricula", matricula);

                sqlCommand.Connection = conexaoBD.Conectar();
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    this.mensagem = "Não foi possível cadastrar o login. Número de matrícula já está em uso!";
                    loginExistente = true;
                }
                dataReader.Close();
            }
            catch (SqlException error)
            {
                this.mensagem = error.Message;
            }
            finally
            {
                conexaoBD.Desconectar();
            }
            return loginExistente;
        }

        private bool verificaMatricula(int matricula)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            SqlDataReader dataReader;
            bool temMatricula = false;
            sqlCommand.CommandText = "select Nr_Matricula from TB_Funcionario where Nr_Matricula = @matricula";
            sqlCommand.Parameters.AddWithValue("@matricula", matricula);
            sqlCommand.Connection = conexaoBD.Conectar();
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                temMatricula = true;
            }
            dataReader.Close();
            conexaoBD.Desconectar();

            return temMatricula;
        }

        public bool CadastrarLogin(int matricula, string login, string senha, string confirmaSenha, char status)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            bool matriculado = false;
            bool cadastroLogin = VerificarCadastro(matricula);
            bool cadastroMatricula = verificaMatricula(matricula);
            if (senha == confirmaSenha)
            {
                try
                {
                    if ((cadastroMatricula) && (!cadastroLogin))
                    {
                        sqlCommand.CommandText = "insert into TB_LoginFuncionario values (@matricula, @login, @senha, @status);";
                        sqlCommand.Parameters.AddWithValue("@matricula", matricula);
                        sqlCommand.Parameters.AddWithValue("@login", login);
                        sqlCommand.Parameters.AddWithValue("@senha", senha);
                        sqlCommand.Parameters.AddWithValue("@status", status);
                        sqlCommand.Connection = conexaoBD.Conectar();
                        sqlCommand.ExecuteNonQuery();

                        matriculado = true;
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
            }
            else
            {
                this.mensagem = "Confirmação de senha incorreta!";
            }
            return matriculado;
        }

        public int ProcuraMatricula(string login, string senha)
        {
            int matricula = 0;
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexao = new ConexaoBD();
            SqlDataReader dataReader;

            sqlCommand.CommandText = "select * from TB_LoginFuncionario where Ds_Usuario = @login and Ds_Senha = @senha";
            sqlCommand.Parameters.AddWithValue("@login", login);
            sqlCommand.Parameters.AddWithValue("@senha", senha);

            sqlCommand.Connection = conexao.Conectar();
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                matricula = Convert.ToInt32(dataReader["Nr_Matricula"]);
            }
            dataReader.Close();
            conexao.Desconectar();
            return matricula;
        }

        public void InativarLogin(int matricula)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();

            sqlCommand.CommandText = "update TB_LoginFuncionario set St_Ativo = 'I' where Nr_Matricula = @matricula";
            sqlCommand.Parameters.AddWithValue("@matricula", matricula);
            sqlCommand.Connection = conexaoBD.Conectar();

            sqlCommand.ExecuteNonQuery();
            conexaoBD.Desconectar();
        }
    }
}
