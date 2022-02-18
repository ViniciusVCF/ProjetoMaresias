using ProjetoMaresias.Modelo;
using ProjetoMaresias.Login;
using ProjetoMaresias.Statics;
using System;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_RH
{
    public partial class FrmAlteraDadosFuncionario : Form
    {
        public FrmAlteraDadosFuncionario()
        {
            InitializeComponent();
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
                cbxCargo.Items.Add("Analista pleno");
                cbxCargo.Items.Add("Analista senior");
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
                    string mensagem;
                    Funcionario funcionario = new Funcionario();
                    funcionario.IdFuncionario = Convert.ToInt32(txbMatricula.Text);
                    funcionario.Email = txbEmail.Text;
                    funcionario.Celular = mtbCelular.Text;
                    funcionario.Rua = txbRua.Text;
                    funcionario.NumeroEndereco = txbNumeroCasa.Text;
                    funcionario.Bairro = txbBairro.Text;
                    funcionario.Cep = mtbCEP.Text;
                    funcionario.Cidade = txbCidade.Text;
                    funcionario.Estado = cbxUF.Text;
                    funcionario.Departamento = cbxDepartamento.Text;
                    funcionario.Cargo = cbxCargo.Text;
                    funcionario.Salario = Convert.ToDouble(txbSalario.Text);
                    if (cbxStatus.Text == "I")
                    {
                        funcionario.DataDemissao = DateTime.Today;
                    }
                    funcionario.Status = Convert.ToChar(cbxStatus.Text);

                    if (MessageBox.Show("Em caso de inativação, a ação será irreversível.\nDeseja alterar os dados?", "Alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        mensagem = funcionario.AlterarDados(funcionario);
                        if (mensagem == "")
                        {
                            MessageBox.Show("Dados alterados com sucesso!", "Alteração de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (cbxStatus.Text == "I")
                            {
                                ComandosLogin comandosLogin = new ComandosLogin();
                                comandosLogin.InativarLogin(Convert.ToInt32(txbMatricula.Text));
                            }
                        }
                        else
                        {
                            MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        this.Close();
                    }
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

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            if (txbMatricula.Text != "" && txbMatricula.Text.Length == 5)
            {
                Funcionario funcionario = new Funcionario();
                funcionario = funcionario.CarregaDados(Convert.ToInt32(txbMatricula.Text));
                if (funcionario.IdFuncionario.ToString() != "0")
                {
                    txbMatricula.Enabled = false;
                    txbNome.Text = funcionario.Nome;
                    mtbRG.Text = funcionario.Rg.ToString();
                    mtbCPF.Text = funcionario.Cpf.ToString();
                    dtpDataNascimento.Text = funcionario.DataNascimento.ToString("d");
                    txbEmail.Text = funcionario.Email.ToString();
                    mtbCelular.Text = funcionario.Celular.ToString();
                    txbRua.Text = funcionario.Rua.ToString();
                    txbNumeroCasa.Text = funcionario.NumeroEndereco.ToString();
                    txbBairro.Text = funcionario.Bairro.ToString();
                    mtbCEP.Text = funcionario.Cep.ToString();
                    txbCidade.Text = funcionario.Cidade.ToString();
                    cbxUF.Text = funcionario.Estado.ToString();
                    cbxDepartamento.Text = funcionario.Departamento.ToString();
                    mtbDataAdmissao.Text = funcionario.DataAdmissao.ToString("d");
                    cbxCargo.Items.Add(funcionario.Cargo.ToString());
                    cbxCargo.Text = funcionario.Cargo.ToString();
                    if (funcionario.DataDemissao.ToString("d") != "01/01/0001")
                    {
                        mtbDataDemissao.Text = funcionario.DataDemissao.ToString("d");
                    }
                    else
                    {
                        mtbDataDemissao.Text = "";
                    }
                    txbSalario.Text = funcionario.Salario.ToString();
                    cbxStatus.Text = funcionario.Status.ToString();
                    if (cbxStatus.Text != "I")
                    {
                        btnAlterar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Número de matrícula não cadastrado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Número de matrícula não informado ou inválido!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txbNome.Enabled = true;
            mtbRG.Enabled = true;
            mtbCPF.Enabled = true;
            dtpDataNascimento.Enabled = true;
            txbEmail.Enabled = true;
            mtbCelular.Enabled = true;
            txbRua.Enabled = true;
            txbNumeroCasa.Enabled = true;
            txbBairro.Enabled = true;
            mtbCEP.Enabled = true;
            txbCidade.Enabled = true;
            cbxUF.Enabled = true;
            cbxDepartamento.Enabled = true;
            cbxCargo.Enabled = true;
            txbSalario.Enabled = true;
            cbxStatus.Enabled = true;

            btnAlterar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void FrmAlteraDadosFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuRH frmMenuRH = new FrmMenuRH();
            frmMenuRH.Show();
        }
    }
}
