using ProjetoMaresias.Modelo;
using ProjetoMaresias.Statics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_Quarto
{
    public partial class FrmAlterarDadosQuarto : Form
    {
        public FrmAlterarDadosQuarto()
        {
            InitializeComponent();
        }

        private void pnlDadosQuarto_Validated(object sender, EventArgs e)
        {
            eprDadoInvalido.Clear();
            if (txbDescricao.Text.Length > 100)
            {
                eprDadoInvalido.SetError(txbDescricao, "Quantidade de caracteres excedida!");
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

        private void numeroDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txbDescricao.Enabled = true;
            txbAndar.Enabled = true;
            txbDiaria.Enabled = true;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            if (txbNumero.Text != "" && txbNumero.Text.Length <= 4)
            {
                Quarto quarto = new Quarto();
                quarto = quarto.CarregaDados(Convert.ToInt32(txbNumero.Text));
                if (quarto.Numero.ToString() != "0")
                {
                    txbNumero.Enabled = false;
                    txbNumero.Text = quarto.Numero.ToString();
                    txbDescricao.Text = quarto.Descricao;
                    txbAndar.Text = quarto.Andar.ToString();
                    txbDiaria.Text = quarto.Diaria.ToString();
                    btnAlterar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Número de quarto não cadastrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Número de quarto não informado ou inválido!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosQuarto))
            {
                if (!Validacao.DadosInvalidos(eprDadoInvalido, pnlDadosQuarto))
                {
                    Quarto quarto = new Quarto();
                    quarto.Numero = Convert.ToInt32(txbNumero.Text);
                    quarto.Descricao = txbDescricao.Text;
                    quarto.Andar = Convert.ToInt32(txbAndar.Text);
                    quarto.Diaria = Convert.ToDouble(txbDiaria.Text);

                    string mensagem = quarto.AlterarDados(quarto);
                    if (mensagem == "")
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

        private void FrmAlterarDadosQuarto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuQuarto frmMenuQuarto = new FrmMenuQuarto();
            frmMenuQuarto.Show();
        }
    }
}
