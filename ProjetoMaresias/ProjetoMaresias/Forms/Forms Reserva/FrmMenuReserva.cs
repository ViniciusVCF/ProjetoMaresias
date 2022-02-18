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
    public partial class FrmMenuReserva : Form
    {
        public FrmMenuReserva()
        {
            InitializeComponent();
        }

        private void imgCadastrarReserva_Click(object sender, EventArgs e)
        {
            FrmCadastroReserva frmCadastroReserva = new FrmCadastroReserva();
            frmCadastroReserva.Show();
            this.Close();
        }


        private void imgConsultarReserva_Click(object sender, EventArgs e)
        {
            FrmConsultaReserva frmConsultaReserva = new FrmConsultaReserva();
            frmConsultaReserva.Show();
            this.Close();
        }

        private void imgCancelarReserva_Click(object sender, EventArgs e)
        {
            FrmAlterarStatusReserva frmAlterarStatusReserva = new FrmAlterarStatusReserva();
            frmAlterarStatusReserva.Show();
            this.Close();
        }
    }
}
