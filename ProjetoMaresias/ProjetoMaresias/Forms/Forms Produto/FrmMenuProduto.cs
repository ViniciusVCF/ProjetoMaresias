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
    public partial class FrmMenuProduto : Form
    {
        public FrmMenuProduto()
        {
            InitializeComponent();
        }

        private void imgCadastrarProduto_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
            frmCadastroProduto.Show();
            this.Close();
        }

        private void imgEditarProduto_Click(object sender, EventArgs e)
        {
            FrmAlterarDadosProduto frmAlterarDadosProduto = new FrmAlterarDadosProduto();
            frmAlterarDadosProduto.Show();
            this.Close();
        }

        private void imgConsultarProduto_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto frmConsultaProduto = new FrmConsultaProduto();
            frmConsultaProduto.Show();
            this.Close();
        }
    }
}
