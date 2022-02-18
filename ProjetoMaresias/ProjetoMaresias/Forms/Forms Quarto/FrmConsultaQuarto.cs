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

namespace ProjetoMaresias.Forms.Forms_Quarto
{
    public partial class FrmConsultaQuarto : Form
    {
        public FrmConsultaQuarto()
        {
            InitializeComponent();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            dgvDadosQuarto.DataSource = quarto.Consultar(txbDescQuarto.Text);
        }

        private void FrmConsultaQuarto_Load(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            dgvDadosQuarto.DataSource = quarto.Consultar(txbDescQuarto.Text);
        }

        private void FrmConsultaQuarto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuQuarto frmMenuQuarto = new FrmMenuQuarto();
            frmMenuQuarto.Show();
        }
    }
}
