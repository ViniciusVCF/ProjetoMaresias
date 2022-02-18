using ProjetoMaresias.Modelo;
using ProjetoMaresias.Statics;
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
    public partial class FrmCadastroReserva : Form
    {
        public FrmCadastroReserva()
        {
            InitializeComponent();
        }

        private void pnlDadosReserva_Validated(object sender, EventArgs e)
        {
            eprDadoInvalido.Clear();
            if (txbNumReserva.Text.Length > 4)
            {
                eprDadoInvalido.SetError(txbNumReserva, "Apenas números com 4 dígitos!");
            }
            if (txbCodCliente.Text.Length > 7 || txbNomeCliente.Text == "")
            {
                eprDadoInvalido.SetError(txbCodCliente, "Código de cliente inexistente!");
            }
            if(txbDescQuarto.Text == "")
            {
                eprDadoInvalido.SetError(txbNumQuarto, "Número de quarto inexistente!");
            }
            if(dtpDataEntrada.Text == dtpDataSaida.Text)
            {
                eprDadoInvalido.SetError(dtpDataSaida, "Data de saída e entrada são iguais!");
            }
            if(Convert.ToDateTime(dtpDataEntrada.Text) < DateTime.Today)
            {
                eprDadoInvalido.SetError(dtpDataEntrada, "Data de entrada inferior a data atual!");
            }
            if (Convert.ToDateTime(dtpDataEntrada.Text) > Convert.ToDateTime(dtpDataSaida.Text))
            {
                eprDadoInvalido.SetError(dtpDataSaida, "Data de saída inferior a data de entrada!");
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosReserva))
            {
                if (!Validacao.DadosInvalidos(eprDadoInvalido, pnlDadosReserva))
                {
                    Reserva reserva = new Reserva();
                    reserva.IdCliente = Convert.ToInt32(txbCodCliente.Text);
                    reserva.NomeCliente = txbNomeCliente.Text;
                    reserva.Status = cbxStatus.Text;
                    reserva.DataEntrada = Convert.ToDateTime(dtpDataEntrada.Text);
                    reserva.DataSaida = Convert.ToDateTime(dtpDataSaida.Text);
                    reserva.NumeroQuarto = Convert.ToInt32(txbNumQuarto.Text);
                    reserva.DescricaoQuarto = txbDescQuarto.Text;
                    string mensagem = reserva.Cadastrar(reserva);
                    if (mensagem == "")
                    {
                        reserva.Cadastrar(reserva);
                        MessageBox.Show("Reserva cadastrada com sucesso!", "Cadastro de reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CarregaDados_Validated(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            if(txbNumQuarto.Text == "" || txbNomeCliente.Text == "")
            {
                reserva = reserva.DadosCadastro("", 0);
            }
            else
            {
                reserva = reserva.DadosCadastro(txbNomeCliente.Text, Convert.ToInt32(txbNumQuarto.Text));
            }
            txbCodCliente.Text = reserva.IdCliente.ToString();
            txbDescQuarto.Text = reserva.DescricaoQuarto;
        }

        private void FrmCadastroReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuReserva frmMenuReserva = new FrmMenuReserva();
            frmMenuReserva.Show();
        }
    }
}