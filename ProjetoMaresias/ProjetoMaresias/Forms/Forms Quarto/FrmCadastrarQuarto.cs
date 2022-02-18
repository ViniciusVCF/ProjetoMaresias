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
    public partial class FrmCadastrarQuarto : Form
    {
        public FrmCadastrarQuarto()
        {
            InitializeComponent();
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
                    string mensagem = quarto.Cadastrar(quarto);
                    if (mensagem == "")
                    {
                        MessageBox.Show("Quarto cadastrado com sucesso!", "Cadastro de quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pnlDadosQuarto_Validated(object sender, EventArgs e)
        {
            eprDadoInvalido.Clear();
            if (txbNumero.Text.Length > 4)
            {
                eprDadoInvalido.SetError(txbNumero, "Apenas números com 4 dígitos!");
            }
            if(txbNumero.Text == "0" || txbNumero.Text == "00" || txbNumero.Text == "000" || txbNumero.Text == "0000")
            {
                eprDadoInvalido.SetError(txbNumero, "Número inválido!");
            }
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

        private void FrmCadastrarQuarto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuQuarto frmMenuQuarto = new FrmMenuQuarto();
            frmMenuQuarto.Show();
        }
    }
}
