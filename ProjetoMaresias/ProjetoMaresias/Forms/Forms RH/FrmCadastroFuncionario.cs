using ProjetoMaresias.Modelo;
using System;
using System.Windows.Forms;
using ProjetoMaresias.Statics;

namespace ProjetoMaresias.Forms.Forms_RH
{
    public partial class FrmCadastroFuncionario : Form
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
            mtbDataAdmissao.Text = DateTime.Now.ToString("d");
        }

        private void cbxDepartamento_Validated(object sender, EventArgs e)
        {
            cbxCargo.Items.Clear();
            string departamento = cbxDepartamento.Text;
            if (departamento == "Gerencia geral")
            {
                cbxCargo.Items.Add("Gerente");
            }
            else if (departamento == "Financeiro" || departamento == "Marketing" || departamento == "Comercial" || departamento == "Recursos humanos")
            {
                cbxCargo.Items.Add("Auxiliar administrativo");
                cbxCargo.Items.Add("Analista jr");
                cbxCargo.Items.Add("Analista pl");
                cbxCargo.Items.Add("Analista sr");
                cbxCargo.Items.Add("Supervisor");
                cbxCargo.Items.Add("Gerente");
            }
            else if (departamento == "Alimentos")
            {
                cbxCargo.Items.Add("Assistente de A&B");
                cbxCargo.Items.Add("Maître");
                cbxCargo.Items.Add("Sommelier");
                cbxCargo.Items.Add("Garçom");
                cbxCargo.Items.Add("Gerente");
                cbxCargo.Items.Add("Supervisor");
            }
            else if (departamento == "Governança")
            {
                cbxCargo.Items.Add("Gerente");
                cbxCargo.Items.Add("Supervisor");
                cbxCargo.Items.Add("Camareira");
                cbxCargo.Items.Add("Arrumador");
            }
            else if (departamento == "Recepção")
            {
                cbxCargo.Items.Add("Recepcionista");
                cbxCargo.Items.Add("Telefonista");
                cbxCargo.Items.Add("Mensageiro");
                cbxCargo.Items.Add("Gerente");
                cbxCargo.Items.Add("Supervisor");
            }
            else if (departamento == "Manutenção")
            {
                cbxCargo.Items.Add("Auxiliar de manutenção");
                cbxCargo.Items.Add("Gerente");
                cbxCargo.Items.Add("Supervisor");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosFuncionario))
            {
                if (!Validacao.DadosInvalidos(eprDadoInvalido, pnlDadosFuncionario))
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.Nome = txbNome.Text;
                    funcionario.Rg = mtbRG.Text;
                    funcionario.Cpf = mtbCPF.Text;
                    funcionario.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                    funcionario.Email = txbEmail.Text;
                    funcionario.Celular = mtbCelular.Text;
                    funcionario.Rua = txbRua.Text;
                    funcionario.NumeroEndereco = txbNumeroCasa.Text;
                    funcionario.Bairro = txbBairro.Text;
                    funcionario.Cep = mtbCEP.Text;
                    funcionario.Cidade = txbCidade.Text;
                    funcionario.Estado = cbxUF.Text;
                    funcionario.Departamento = cbxDepartamento.Text;
                    funcionario.DataAdmissao = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
                    funcionario.Cargo = cbxCargo.Text;
                    funcionario.Salario = Convert.ToDouble(txbSalario.Text);
                    funcionario.Status = Convert.ToChar(cbxStatus.Text);
                    string mensagem = funcionario.Cadastrar(funcionario);
                    if (mensagem == "")
                    {
                        MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro de funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Um ou mais campos inválidos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existem informações sem preenchimento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numeroDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void somenteNumeros(object sender, KeyPressEventArgs e)
        {
            Restricao.SomenteNumeros(sender, e);
        }

        private void space_KeyDown(object sender, KeyEventArgs e)
        {
            Restricao.BotaoEspaco(sender, e);
        }

        private void pnlDadosFuncionario_Validated(object sender, EventArgs e)
        {
            eprDadoInvalido.Clear();
            if (!Validacao.ValidaCPF(mtbCPF.Text))
            {
                eprDadoInvalido.SetError(mtbCPF, "CPF inválido");
            }
            if (!Validacao.ValidaEmail(txbEmail.Text))
            {
                eprDadoInvalido.SetError(txbEmail, "Email inválido!");
            }
            if (mtbRG.Text.Length < 9)
            {
                eprDadoInvalido.SetError(mtbRG, "RG Inválido!");
            }
            if (txbNumeroCasa.Text.Length > 5)
            {
                eprDadoInvalido.SetError(txbNumeroCasa, "Número inválido!");
            }
            if (mtbCEP.Text.Length < 8)
            {
                eprDadoInvalido.SetError(mtbCEP, "CEP inválido!");
            }
            if (mtbCelular.Text.Length < 11)
            {
                eprDadoInvalido.SetError(mtbCelular, "Número inválido!");
            }
            if (dtpDataNascimento.Text == (DateTime.Now.ToString("d")))
            {
                eprDadoInvalido.SetError(dtpDataNascimento, "Data de nascimento não pode ser a atual!");
            }
        }

        private void FrmCadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuRH frmMenuRH = new FrmMenuRH();
            frmMenuRH.Show();
        }
    }
}
