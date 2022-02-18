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

namespace ProjetoMaresias.Forms.Forms_Gastos
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();

            dgvDadosRelatorio.DataSource = compras.Relatorio(Convert.ToDateTime(dtpDataInicio.Text), Convert.ToDateTime(dtpDataFinal.Text));
        }

        private void FrmRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuGastos frmMenuGastos = new FrmMenuGastos();
            frmMenuGastos.Show();
        }
    }
}
