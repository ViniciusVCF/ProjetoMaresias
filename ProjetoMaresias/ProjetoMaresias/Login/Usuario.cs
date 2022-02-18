using ProjetoMaresias.ConexoesBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMaresias.Login
{
    class Usuario
    {
        private int _matricula;
        private string _nome;
        private string _username;
        private string _senha;

        public int Matricula { get => _matricula; set => _matricula = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Username { get => _username; set => _username = value; }
        public string Senha { get => _senha; set => _senha = value; }

        public Usuario DadosUsuario(int matricula)
        {
            Usuario user = new Usuario();
            DALComandosUsuario comandosUsuario = new DALComandosUsuario();
            user = comandosUsuario.DadosUsuario(matricula);
            return user;
        }
        public string AlterarSenha(int matricula, string senha, string confirmaSenha)
        {
            string mensagem = "";
            DALComandosUsuario comandosUsuario = new DALComandosUsuario();
            try
            {
                if(senha != "" && confirmaSenha == "")
                {
                    mensagem = "Confirmação de senha não preenchido!";
                }
                else if(senha == "" && confirmaSenha == "")
                {
                    mensagem = "Nenhum dado informado para nova senha!";
                }
                else if(senha.Length > 15)
                {
                    mensagem = "Limite de caracteres atingido! Insira uma senha com no máximo 15 caracteres.";
                }
                else if(senha == confirmaSenha)
                {
                    comandosUsuario.AlterarSenha(matricula, senha);
                }
                else
                {
                    mensagem = "Confirmação de senha incorreta!";
                }
            }
            catch(SqlException)
            {
                mensagem = "Erro com Banco de Dados!";
            }
            return mensagem;
        }
    }
}
