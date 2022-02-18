using ProjetoMaresias.Forms.Forms_Hospedagem;
using ProjetoMaresias.Forms.Forms_Reserva;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_Recepcao
{
    public partial class FrmMenuRecepcao : Form
    {
        public FrmMenuRecepcao()
        {
            InitializeComponent();
        }

        private void imgCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente();
            frmCadastrarCliente.Show();
            this.Close();
        }

        private void imgAlterarDadosCliente_Click(object sender, EventArgs e)
        {
            FrmAlteraDadosCliente frmAlteraDadosCliente = new FrmAlteraDadosCliente();
            frmAlteraDadosCliente.Show();
            this.Close();
        }

        private void imgLocalizarCliente_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente frmConsultarCliente = new FrmConsultarCliente();
            frmConsultarCliente.Show();
            this.Close();
        }

        private void imgReserva_Click(object sender, EventArgs e)
        {
            FrmMenuReserva frmMenuReserva = new FrmMenuReserva();
            frmMenuReserva.Show();
            this.Close();
        }

        private void imgHospedagem_Click(object sender, EventArgs e)
        {
            FrmMenuHospedagem frmMenuHospedagem = new FrmMenuHospedagem();
            frmMenuHospedagem.Show();
            this.Close();
        }
    }
}
