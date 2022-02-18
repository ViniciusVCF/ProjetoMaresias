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

namespace ProjetoMaresias.Forms.Forms_Reserva
{
    public partial class FrmConsultaReserva : Form
    {
        public FrmConsultaReserva()
        {
            InitializeComponent();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            dgvDadosReserva.DataSource = reserva.Consultar(txbNomeCliente.Text, cbxStatus.Text);
        }

        private void FrmConsultaReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuReserva frmMenuReserva = new FrmMenuReserva();
            frmMenuReserva.Show();
        }

        private void FrmConsultaReserva_Load(object sender, EventArgs e)
        {
            cbxStatus.SelectedIndex = 0;
        }
    }
}
