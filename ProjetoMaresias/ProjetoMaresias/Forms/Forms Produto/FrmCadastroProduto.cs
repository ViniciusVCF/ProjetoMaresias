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
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosQuarto))
            {
                Produto produto = new Produto();
                produto.DescricaoProduto = txbDescricao.Text;
                produto.Categoria = (Categoria)Enum.Parse(typeof(Categoria), cbxCategoria.Text);
                produto.Quantidade = Convert.ToInt32(txbQuantidade.Text);
                produto.Preco = Convert.ToDouble(txbPreco.Text);
                produto.Status = Convert.ToChar(cbxStatus.Text);

                string mensagem = produto.Cadastrar(produto);
                if (mensagem == "")
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            cbxStatus.SelectedIndex = 0;

            Array itens = Enum.GetNames(typeof(Categoria));

            foreach (string item in itens)
            {
                cbxCategoria.Items.Add(item);
            }
        }
        private void numeroDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
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

        private void FrmCadastroProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuProduto frmMenuProduto = new FrmMenuProduto();
            frmMenuProduto.Show();
        }
    }
}
