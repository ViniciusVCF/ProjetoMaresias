using ProjetoMaresias.Enums;
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

namespace ProjetoMaresias.Forms.Forms_Produto
{
    public partial class FrmAlterarDadosProduto : Form
    {
        public FrmAlterarDadosProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosQuarto))
            {
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(txbCodigo.Text);
                produto.DescricaoProduto = txbDescricao.Text;
                produto.Categoria = (Categoria)Enum.Parse(typeof(Categoria), cbxCategoria.Text);
                produto.Quantidade = Convert.ToInt32(txbQuantidade.Text);
                produto.Preco = Convert.ToDouble(txbPreco.Text);
                produto.Status = Convert.ToChar(cbxStatus.Text);

                string mensagem = produto.AlterarDados(produto);
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
                MessageBox.Show("Existem informações sem preenchimento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txbDescricao.Enabled = true;
            cbxCategoria.Enabled = true;
            txbQuantidade.Enabled = true;
            txbPreco.Enabled = true;
            cbxStatus.Enabled = true;

            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            if (txbCodigo.Text != "")
            {
                Produto produto = new Produto();
                produto = produto.CarregarDados(Convert.ToInt32(txbCodigo.Text));
                if (produto.IdProduto.ToString() != "0")
                {
                    txbCodigo.Enabled = false;
                    txbDescricao.Text = produto.DescricaoProduto.ToString();
                    cbxCategoria.Text = produto.Categoria.ToString();
                    txbQuantidade.Text = produto.Quantidade.ToString();
                    txbPreco.Text = produto.Preco.ToString("F2");
                    cbxStatus.Text = produto.Status.ToString();

                    btnAlterar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código de produto não cadastrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Código de produto não informado ou inválido!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FrmAlterarDadosProduto_Load(object sender, EventArgs e)
        {
            cbxStatus.SelectedIndex = 0;

            Array itens = Enum.GetNames(typeof(Categoria));

            foreach (string item in itens)
            {
                cbxCategoria.Items.Add(item);
            }
        }

        private void FrmAlterarDadosProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuProduto frmMenuProduto = new FrmMenuProduto();
            frmMenuProduto.Show();
        }
    }
}
