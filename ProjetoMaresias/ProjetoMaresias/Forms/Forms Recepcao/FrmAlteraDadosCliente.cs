using ProjetoMaresias.Modelo;
using ProjetoMaresias.Statics;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_Recepcao
{
    public partial class FrmAlteraDadosCliente : Form
    {
        public FrmAlteraDadosCliente()
        {
            InitializeComponent();
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

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            if (txbCodCliente.Text != "" && txbCodCliente.Text.Length == 7)
            {
                Cliente cliente = new Cliente();
                cliente = cliente.CarregaDados(Convert.ToInt32(txbCodCliente.Text));
                if (cliente.IdCliente.ToString() != "0")
                {
                    txbCodCliente.Enabled = false;
                    txbCodCliente.Text = cliente.IdCliente.ToString();
                    txbNome.Text = cliente.Nome;
                    mtbRG.Text = cliente.Rg.ToString();
                    mtbCPF.Text = cliente.Cpf.ToString();
                    txbEmail.Text = cliente.Email.ToString();
                    mtbCelular.Text = cliente.Celular.ToString();
                    btnAlterar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código de cliente não cadastrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Código de cliente não informado ou inválido!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txbNome.Enabled = true;
            mtbRG.Enabled = true;
            mtbCPF.Enabled = true;
            txbEmail.Enabled = true;
            mtbCelular.Enabled = true;

            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosCliente))
            {
                if (!Validacao.DadosInvalidos(eprDadoInvalido, pnlDadosCliente))
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(txbCodCliente.Text);
                    cliente.Nome = txbNome.Text.ToString();
                    cliente.Cpf = mtbCPF.Text.ToString();
                    cliente.Rg = mtbRG.Text.ToString();
                    cliente.Email = txbEmail.Text.ToString();
                    cliente.Celular = mtbCelular.Text.ToString();

                    string mensagem = cliente.AlterarDados(cliente);
                    if(mensagem == "")
                    {
                        MessageBox.Show("Dados alterados com sucesso!", "Alteração de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
