using System;
using System.Windows.Forms;
using ProjetoMaresias.Forms.Forms_RH;

namespace ProjetoMaresias.Forms
{
    public partial class FrmMenuRH : Form
    {
        public FrmMenuRH()
        {
            InitializeComponent();
        }

        private void imgCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
            frmCadastroFuncionario.Show();
            this.Close();
        }

        private void imgAlterar_Click(object sender, EventArgs e)
        {
            FrmAlteraDadosFuncionario frmAlteraDadosFuncionario = new FrmAlteraDadosFuncionario();
            frmAlteraDadosFuncionario.Show();
            this.Close();
        }

        private void imgRecepcao_Click(object sender, EventArgs e)
        {
            FrmConsultarFuncionario frmConsultarFuncionario = new FrmConsultarFuncionario();
            frmConsultarFuncionario.Show();
            this.Close();
        }
    }
}
