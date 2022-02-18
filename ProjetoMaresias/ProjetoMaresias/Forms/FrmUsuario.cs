using ProjetoMaresias.Login;
using System;
using System.Media;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms
{
    public partial class FrmUsuario : Form
    {
        public int Matricula;

        public FrmUsuario(int matricula)
        {
            InitializeComponent();
            this.Matricula = matricula;
        }

        private void lbkAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txbSenha.Enabled = true;
            txbSenha.Text = "";
            txbConfirmaSenha.Enabled = true;
            txbConfirmaSenha.Text = "";
            btnSalvar.Enabled = true;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = usuario.DadosUsuario(Matricula);
            string[] primeiroNome = usuario.Nome.Split(' ');
            lblNome.Text = primeiroNome[0];
            txbMatricula.Text = usuario.Matricula.ToString();
            txbUsuario.Text = usuario.Username;
            txbSenha.Text = usuario.Senha;
            txbConfirmaSenha.Text = usuario.Senha;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario = usuario.DadosUsuario(Matricula);
            string mensagem = usuario.AlterarSenha(Matricula, txbSenha.Text, txbConfirmaSenha.Text);
            if(usuario.Senha == txbSenha.Text)
            {
                MessageBox.Show("Nova senha não pode ser igual a senha atual!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(mensagem == "")
            {
                MessageBox.Show("Senha alterada com sucesso!", "Alteração de senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        private void txb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
                SystemSounds.Beep.Play();
            }
        }
    }
}
