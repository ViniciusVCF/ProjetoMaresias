using ProjetoMaresias.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoMaresias.ConexoesBD
{
    class DALComandosFuncionario
    {
        public string mensagem = "";

        private bool verificarCadastro(string cpf)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            bool cadastrado = false;
            SqlDataReader dataReader;
            sqlCommand.CommandText = "select Nr_CPF from TB_Funcionario where Nr_CPF = @cpf";
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

        public string Cadastrar(Funcionario funcionario)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                if (!verificarCadastro(funcionario.Cpf))
                {
                    sqlCommand.CommandText = "insert into TB_Funcionario values (@status, @nome, @rg, @cpf, @dataNascimento, @email, @celular, " +
                        "@departamento, @cargo, @salario, @cep, @rua, @numeroEndereco, @bairro, @cidade, @estado, @dataAdmissao, @dataDemissao) ; select @@IDENTITY;";

                    sqlCommand.Parameters.AddWithValue("@status", funcionario.Status);
                    sqlCommand.Parameters.AddWithValue("@nome", funcionario.Nome);
                    sqlCommand.Parameters.AddWithValue("@rg", funcionario.Rg);
                    sqlCommand.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                    sqlCommand.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
                    sqlCommand.Parameters.AddWithValue("@email", funcionario.Email);
                    sqlCommand.Parameters.AddWithValue("@celular", funcionario.Celular);
                    sqlCommand.Parameters.AddWithValue("@departamento", funcionario.Departamento);
                    sqlCommand.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                    sqlCommand.Parameters.AddWithValue("@salario", funcionario.Salario);
                    sqlCommand.Parameters.AddWithValue("@cep", funcionario.Cep);
                    sqlCommand.Parameters.AddWithValue("@rua", funcionario.Rua);
                    sqlCommand.Parameters.AddWithValue("@numeroEndereco", funcionario.NumeroEndereco);
                    sqlCommand.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                    sqlCommand.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                    sqlCommand.Parameters.AddWithValue("@estado", funcionario.Estado);
                    sqlCommand.Parameters.AddWithValue("@dataAdmissao", funcionario.DataAdmissao);
                    sqlCommand.Parameters.AddWithValue("@dataDemissao", DBNull.Value);

                    sqlCommand.Connection = conexaoBD.Conectar();
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    this.mensagem = "Não foi possível concluir o cadastro, CPF já está cadastrado!";
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

        public DataTable Consultar(string nome, string status)
        {
            ConexaoBD conexaoBD = new ConexaoBD();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TB_Funcionario where Nm_Funcionario" +
                " like '%" + nome + "%' and St_Ativo like '%" + status + "%'", conexaoBD.Conectar());
            dataAdapter.Fill(table);
            conexaoBD.Desconectar();
            return table;
        }

        public Funcionario CarregaDados(int matricula)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            Funcionario funcionario = new Funcionario();

            sqlCommand.CommandText = "select * from TB_Funcionario where Nr_Matricula = @matricula";
            sqlCommand.Parameters.AddWithValue("@matricula", matricula);
            sqlCommand.Connection = conexaoBD.Conectar();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                funcionario.IdFuncionario = Convert.ToInt32(dataReader["Nr_Matricula"]);
                funcionario.Status = Convert.ToChar(dataReader["St_Ativo"]);
                funcionario.Nome = dataReader["Nm_Funcionario"].ToString();
                funcionario.Rg = dataReader["Nr_RG"].ToString();
                funcionario.Cpf = dataReader["Nr_CPF"].ToString();
                funcionario.DataNascimento = Convert.ToDateTime(dataReader["Dt_Nascimento"]);
                funcionario.Email = dataReader["Ds_Email"].ToString();
                funcionario.Celular = dataReader["Nr_Celular"].ToString();
                funcionario.Departamento = dataReader["Nm_Departamento"].ToString();
                funcionario.Cargo = dataReader["Nm_Cargo"].ToString();
                funcionario.Salario = Convert.ToDouble(dataReader["Vl_Salario"]);
                funcionario.Cep = dataReader["Nr_CEP"].ToString();
                funcionario.Rua = dataReader["Nm_Rua"].ToString();
                funcionario.NumeroEndereco = dataReader["Nr_Endereco"].ToString();
                funcionario.Bairro = dataReader["Nm_Bairro"].ToString();
                funcionario.Cidade = dataReader["Nm_Cidade"].ToString();
                funcionario.Estado = dataReader["Nm_Estado"].ToString();
                funcionario.DataAdmissao = Convert.ToDateTime(dataReader["Dt_Admissao"]);
                if (dataReader["Dt_Demissao"].ToString() != "")
                {
                    funcionario.DataDemissao = Convert.ToDateTime(dataReader["Dt_Demissao"]);
                }
            }
            conexaoBD.Desconectar();
            return funcionario;
        }

        public string Alterar(Funcionario funcionario)
        {
            SqlCommand sqlCommand = new SqlCommand();
            ConexaoBD conexaoBD = new ConexaoBD();
            try
            {
                sqlCommand.CommandText = "update TB_Funcionario set Ds_Email = @email, Nr_Celular = @celular, Nm_Rua = @rua, " +
                    "Nr_Endereco = @numeroEndereco, Nm_Bairro = @bairro, Nr_CEP = @cep, Nm_Cidade = @cidade, Nm_Estado = @estado, Vl_Salario = @salario, St_Ativo = @status, Dt_Demissao = @dataDemissao " +
                    "where Nr_Matricula = @matricula";
                sqlCommand.Parameters.AddWithValue("@email", funcionario.Email);
                sqlCommand.Parameters.AddWithValue("@celular", funcionario.Celular);
                sqlCommand.Parameters.AddWithValue("@rua", funcionario.Rua);
                sqlCommand.Parameters.AddWithValue("@numeroEndereco", funcionario.NumeroEndereco);
                sqlCommand.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                sqlCommand.Parameters.AddWithValue("@cep", funcionario.Cep);
                sqlCommand.Parameters.AddWithValue("@cidade", funcionario.Cidade);
                sqlCommand.Parameters.AddWithValue("@estado", funcionario.Estado);
                sqlCommand.Parameters.AddWithValue("@salario", funcionario.Salario);
                sqlCommand.Parameters.AddWithValue("@status", funcionario.Status);
                if (funcionario.Status == 'I')
                {
                    sqlCommand.Parameters.AddWithValue("@dataDemissao", funcionario.DataDemissao.ToString("yyyy/MM/dd"));
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@dataDemissao", DBNull.Value);
                }
                sqlCommand.Parameters.AddWithValue("@matricula", funcionario.IdFuncionario);

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


