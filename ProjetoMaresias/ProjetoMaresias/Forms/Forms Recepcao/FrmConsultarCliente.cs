using ProjetoMaresias.Modelo;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_Recepcao
{
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            dgvDadosCliente.DataSource = cliente.Consultar(txbNome.Text, mtbCPF.Text);
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            dgvDadosCliente.DataSource = cliente.Consultar(txbNome.Text, mtbCPF.Text);
        }
    }
}
