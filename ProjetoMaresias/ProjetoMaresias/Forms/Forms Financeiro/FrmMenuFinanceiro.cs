using ProjetoMaresias.Forms.Forms_Gastos;
using ProjetoMaresias.Forms.Forms_Produto;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_Financeiro
{
    public partial class FrmMenuFinanceiro : Form
    {
        public FrmMenuFinanceiro()
        {
            InitializeComponent();
        }

        private void imgProdutos_Click(object sender, EventArgs e)
        {
            FrmMenuProduto frmMenuProduto = new FrmMenuProduto();
            frmMenuProduto.Show();
            this.Close();
        }

        private void imgFaturamento_Click(object sender, EventArgs e)
        {
            FrmFaturamento frmFaturamento = new FrmFaturamento();
            frmFaturamento.Show();
            this.Close();
        }

        private void imgGastos_Click(object sender, EventArgs e)
        {
            FrmMenuGastos frmMenuGastos = new FrmMenuGastos();
            frmMenuGastos.Show();
            this.Close();
        }
    }
}
