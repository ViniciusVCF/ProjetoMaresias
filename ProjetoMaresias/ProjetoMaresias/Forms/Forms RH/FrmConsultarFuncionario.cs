using ProjetoMaresias.Modelo;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_RH
{
    public partial class FrmConsultarFuncionario : Form
    {
        public FrmConsultarFuncionario()
        {
            InitializeComponent(); 
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            dgvDadosFuncionario.DataSource = funcionario.Consultar(txbNome.Text, cbxStatus.Text);
        }

        private void FrmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            dgvDadosFuncionario.DataSource = funcionario.Consultar(txbNome.Text, cbxStatus.Text);
        }

        private void FrmConsultarFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuRH frmMenuRH = new FrmMenuRH();
            frmMenuRH.Show();
        }
    }
}
