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
    public partial class FrmMenuQuarto : Form
    {
        public FrmMenuQuarto()
        {
            InitializeComponent();
        }

        private void imgCadastrarQuarto_Click(object sender, EventArgs e)
        {
            FrmCadastrarQuarto frmCadastrarQuarto = new FrmCadastrarQuarto();
            frmCadastrarQuarto.Show();
            this.Close();
        }

        private void imgAlterarDadosQuarto_Click(object sender, EventArgs e)
        {
            FrmAlterarDadosQuarto frmAlterarDadosQuarto = new FrmAlterarDadosQuarto();
            frmAlterarDadosQuarto.Show();
            this.Close();
        }

        private void imgConsultarQuartos_Click(object sender, EventArgs e)
        {
            FrmConsultaQuarto frmConsultaQuarto = new FrmConsultaQuarto();
            frmConsultaQuarto.Show();
            this.Close();
        }

        private void imgDisponiveis_Click(object sender, EventArgs e)
        {
            FrmQuartosDisponiveis frmQuartosDisponiveis = new FrmQuartosDisponiveis();
            frmQuartosDisponiveis.Show();
            this.Close();
        }
    }
}
