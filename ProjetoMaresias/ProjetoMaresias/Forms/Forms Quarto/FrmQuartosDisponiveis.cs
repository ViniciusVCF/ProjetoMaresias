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
    public partial class FrmQuartosDisponiveis : Form
    {
        public FrmQuartosDisponiveis()
        {
            InitializeComponent();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            dgvDadosQuarto.DataSource = quarto.Disponibilidade(Convert.ToDateTime(dtpDataEntrada.Text), Convert.ToDateTime(dtpDataSaida.Text));
        }

        private void FrmQuartosDisponiveis_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuQuarto frmMenuQuarto = new FrmMenuQuarto();
            frmMenuQuarto.Show();
        }
    }
}
