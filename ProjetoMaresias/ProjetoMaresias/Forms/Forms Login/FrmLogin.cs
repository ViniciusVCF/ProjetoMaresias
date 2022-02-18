using ProjetoMaresias.Statics;
using ProjetoMaresias.Forms;
using ProjetoMaresias.Login;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lbkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastroLogin frmCadastroLogin = new FrmCadastroLogin();
            frmCadastroLogin.ShowDialog();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ComandosLogin comandos = new ComandosLogin();
            if(txbUsuario.Text != "" || txbSenha.Text != "")
            {
                comandos.Conectar(txbUsuario.Text, txbSenha.Text);
                if (comandos.mensagem == "")
                {
                    if (comandos.encontrado)
                    {
                        FrmMenuPrincipal frmMenu = new FrmMenuPrincipal(comandos.PegarMatricula(txbUsuario.Text, txbSenha.Text));
                        this.Hide();
                        frmMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login não encontrado, verifique seu usuário e senha", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(comandos.mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha não informado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txb_KeyDown(object sender, KeyEventArgs e)
        {
            Restricao.BotaoEspaco(sender, e);
        }
    }
}
