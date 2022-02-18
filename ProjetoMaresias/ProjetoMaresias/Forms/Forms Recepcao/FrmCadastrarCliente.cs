using ProjetoMaresias.Modelo;
using ProjetoMaresias.Statics;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_Recepcao
{
    public partial class FrmCadastrarCliente : Form
    {
        public FrmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosCliente))
            {
                if (!Validacao.DadosInvalidos(eprDadoInvalido, pnlDadosCliente))
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = txbNome.Text;
                    cliente.Celular = mtbCelular.Text;
                    cliente.Rg = mtbRG.Text;
                    cliente.Cpf = mtbCPF.Text;
                    cliente.Email = txbEmail.Text;
                    string mensagem = cliente.Cadastrar(cliente);
                    if (mensagem == "")
                    {
                        cliente.Cadastrar(cliente);
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Um ou mais campos inválidos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existem informações sem preenchimento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void somenteNumeros(object sender, KeyPressEventArgs e)
        {
            Restricao.SomenteNumeros(sender, e);
        }

        private void space_KeyDown(object sender, KeyEventArgs e)
        {
            Restricao.BotaoEspaco(sender, e);
        }

        private void pnlDadosCliente_Validated(object sender, EventArgs e)
        {
            eprDadoInvalido.Clear();
            if (!Validacao.ValidaCPF(mtbCPF.Text))
            {
                eprDadoInvalido.SetError(mtbCPF, "CPF inválido");
            }
            if (!Validacao.ValidaEmail(txbEmail.Text))
            {
                eprDadoInvalido.SetError(txbEmail, "Email inválido!");
            }
            if (mtbRG.Text.Length < 9)
            {
                eprDadoInvalido.SetError(mtbRG, "RG Inválido!");
            }
            if (mtbCelular.Text.Length < 11)
            {
                eprDadoInvalido.SetError(mtbCelular, "Número inválido!");
            }
        }
    }
}
