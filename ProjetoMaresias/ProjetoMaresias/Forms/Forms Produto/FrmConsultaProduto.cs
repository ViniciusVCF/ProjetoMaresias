using ProjetoMaresias.Modelo;
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
    public partial class FrmConsultaProduto : Form
    {
        public FrmConsultaProduto()
        {
            InitializeComponent();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            dgvDadosProduto.DataSource = produto.Consultar(txbDescProduto.Text, cbxStatus.Text);
        }

        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            dgvDadosProduto.DataSource = produto.Consultar(txbDescProduto.Text, cbxStatus.Text);
        }

        private void FrmConsultaProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuProduto frmMenuProduto = new FrmMenuProduto();
            frmMenuProduto.Show();
        }
    }
}
