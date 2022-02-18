using ProjetoMaresias.Login;
using ProjetoMaresias.Statics;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms
{
    public partial class FrmCadastroLogin : Form
    {
        public FrmCadastroLogin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlCadastroLogin))
            {
                ComandosLogin comandos = new ComandosLogin();
                bool matriculado = comandos.Cadastrar(Convert.ToInt32(txbMatricula.Text), txbUsuario.Text, txbSenha.Text, txbConfirmaSenha.Text, 'A');
                if (comandos.mensagem == "")
                {
                    if (matriculado)
                    {
                        MessageBox.Show("Cadastro criado com sucesso!", "Cadastro login", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }
                    else
                    {
                        MessageBox.Show("Número de matrícula incorreto ou não cadastrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show(comandos.mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existem campos sem preenchimento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void space_KeyDown(object sender, KeyEventArgs e)
        {
            Restricao.BotaoEspaco(sender, e);
        }

        private void somenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restricao.SomenteNumeros(sender, e);
        }
    }
}
