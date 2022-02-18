using ProjetoMaresias.ConexoesBD;
using System;

namespace ProjetoMaresias.Login
{
    class ComandosLogin
    {
        public bool encontrado;
        public string mensagem = "";

        public bool Conectar(string login, string senha)
        {
            DALComandosLogin comandosLoginBD = new DALComandosLogin();
            encontrado = comandosLoginBD.VerificarLogin(login, senha);
            if (comandosLoginBD.mensagem != "")
            {
                this.mensagem = comandosLoginBD.mensagem;
            }
            return encontrado;
        }

        public bool Cadastrar(int matricula, string login, string senha, string confirmaSenha, char status)
        {
            bool matriculado = false;
            DALComandosLogin comandosLoginBD = new DALComandosLogin();

            matriculado = comandosLoginBD.CadastrarLogin(Convert.ToInt32(matricula), login, senha, confirmaSenha, status);
            if (login.Length > 15)
            {
                this.mensagem = "Limite de caracteres atingido! Insira um usuário com no máximo 15 caracteres.";
            }
            else if (senha.Length > 15)
            {
                this.mensagem = "Limite de caracteres atingido! Insira uma senha com no máximo 15 caracteres.";
            }
            else if (comandosLoginBD.mensagem != "")
            {
                this.mensagem = comandosLoginBD.mensagem;
            }
            return matriculado;
        }

        public int PegarMatricula(string login, string senha)
        {
            DALComandosLogin comandosLoginBD = new DALComandosLogin();
            return comandosLoginBD.ProcuraMatricula(login, senha);
        }

        public void InativarLogin(int matricula)
        {
            DALComandosLogin comandosLogin = new DALComandosLogin();
            comandosLogin.InativarLogin(matricula);
        }
    }
}
