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

namespace ProjetoMaresias.Forms.Forms_Gastos
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            cbxDescProduto.DataSource = compras.ConsultarProduto();
            cbxDescProduto.ValueMember = "Ds_Produto";
            cbxDescProduto.SelectedItem = "";
            cbxDescProduto.Refresh();
            cbxDescProduto.SelectedIndex = -1;

        }

        private void cbxDescProduto_TextChanged(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto = produto.ProcuraProduto(cbxDescProduto.Text);
            txbCodigo.Text = produto.IdProduto.ToString();
            txbPreco.Text = produto.Preco.ToString("F2");
            double precoTotal = Convert.ToInt32(txbQuantidade.Text) * Convert.ToDouble(txbPreco.Text);
            if (precoTotal == 0)
            {
                txbValorTotal.Text = txbPreco.Text;
            }
            else
            {
                txbValorTotal.Text = precoTotal.ToString("F2");
            }
        }

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {
            double total;
            if (txbPreco.Text == "")
            {
                total = 0.0;
            }
            else
            {
                total = 0 + (Convert.ToDouble(txbPreco.Text) * Convert.ToInt32(txbQuantidade.Text));
            }
            txbValorTotal.Text = total.ToString("F2");
        }

        private void pnlDadosCompras_Validated(object sender, EventArgs e)
        {
            eprDadoInvalido.Clear();
            if (Convert.ToInt32(txbQuantidade.Text) <= 0)
            {
                eprDadoInvalido.SetError(txbQuantidade, "Quantidade deve ser maior que 0");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosCompras))
            {
                if (!Validacao.DadosInvalidos(eprSemPreenchimento, pnlDadosCompras))
                {
                    Compras compras = new Compras();

                    compras.IdProduto = Convert.ToInt32(txbCodigo.Text);
                    compras.DescricaoProduto = cbxDescProduto.Text;
                    compras.Quantidade = Convert.ToInt32(txbQuantidade.Text);
                    compras.Preco = Convert.ToDouble(txbPreco.Text);
                    compras.ValorTotal = Convert.ToDouble(txbPreco.Text);
                    compras.DataPagamento = Convert.ToDateTime(dtpData.Text);

                    string mensagem = compras.Cadastrar(compras);
                    if (mensagem == "")
                    {
                        MessageBox.Show("Compra incluída com sucesso!", "Inclusão de compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existem dados incorretos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existem informações sem preenchimento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void space_KeyDown(object sender, KeyEventArgs e)
        {
            Restricao.BotaoEspaco(sender, e);
        }

        private void somenteNumeros(object sender, KeyPressEventArgs e)
        {
            Restricao.SomenteNumeros(sender, e);
        }

        private void FrmCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuGastos frmMenuGastos = new FrmMenuGastos();
            frmMenuGastos.Show();
        }
    }
}
