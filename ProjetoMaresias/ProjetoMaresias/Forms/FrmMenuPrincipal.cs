using ProjetoMaresias.Forms.Forms_Financeiro;
using ProjetoMaresias.Forms.Forms_Quarto;
using ProjetoMaresias.Forms.Forms_Recepcao;
using ProjetoMaresias.Modelo;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public int Matricula;

        public FrmMenuPrincipal(int matricula)
        {
            InitializeComponent();
            this.Matricula = matricula;
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void imgUser_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(Matricula);
            frmUsuario.Show();
        }

        private void imgRH_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario = funcionario.CarregaDados(this.Matricula);
            if(funcionario.Departamento == "Recursos humanos" || funcionario.Departamento == "Gerencia geral")
            {
                FrmMenuRH frmMenuRH = new FrmMenuRH();
                frmMenuRH.Show();
            }
            else
            {
                MessageBox.Show("Acesso não permitido!", "Permissão de acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgRecepcao_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario = funcionario.CarregaDados(this.Matricula);
            if (funcionario.Departamento == "Recepção" || funcionario.Departamento == "Gerencia geral")
            {
                FrmMenuRecepcao frmMenuRecepcao = new FrmMenuRecepcao();
                frmMenuRecepcao.Show();
            }
            else
            {
                MessageBox.Show("Acesso não permitido!", "Permissão de acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgQuartos_Click(object sender, EventArgs e)
        {
            FrmMenuQuarto frmMenuQuarto = new FrmMenuQuarto();
            frmMenuQuarto.Show();
        }

        private void imgFinanceiro_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario = funcionario.CarregaDados(this.Matricula);
            if (funcionario.Departamento == "Financeiro" || funcionario.Departamento == "Gerencia geral")
            {
                FrmMenuFinanceiro frmMenuFinanceiro = new FrmMenuFinanceiro();
                frmMenuFinanceiro.Show();
            }
            else
            {
                MessageBox.Show("Acesso não permitido!", "Permissão de acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
