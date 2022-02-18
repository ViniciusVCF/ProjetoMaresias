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
    public partial class FrmAlterarStatusReserva : Form
    {
        public FrmAlterarStatusReserva()
        {
            InitializeComponent();
        }

        private void somenteNumeros(object sender, KeyPressEventArgs e)
        {
            Restricao.SomenteNumeros(sender, e);
        }

        private void space_KeyDown(object sender, KeyEventArgs e)
        {
            Restricao.BotaoEspaco(sender, e);
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            if (txbNumReserva.Text != "" && txbNumReserva.Text.Length == 4)
            {
                Reserva reserva = new Reserva();
                reserva = reserva.CarregarDados(Convert.ToInt32(txbNumReserva.Text));
                txbNumReserva.Enabled = false;
                txbCodCliente.Text = reserva.IdCliente.ToString();
                txbNomeCliente.Text = reserva.NomeCliente;
                txbNumQuarto.Text = reserva.NumeroQuarto.ToString();
                txbDescQuarto.Text = reserva.DescricaoQuarto;
                cbxStatus.Text = reserva.Status;
                dtpDataEntrada.Text = reserva.DataEntrada.ToString();
                dtpDataSaida.Text = reserva.DataSaida.ToString();

                if (cbxStatus.Text == "Agendado\t")
                {
                    cbxStatus.Enabled = true;
                    btnSalvar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Número de reserva não informado ou inválido!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            reserva.CodReserva = Convert.ToInt32(txbNumReserva.Text);
            reserva.IdCliente = Convert.ToInt32(txbCodCliente.Text);
            reserva.NomeCliente = txbNomeCliente.Text;
            reserva.NumeroQuarto = Convert.ToInt32(txbNumQuarto.Text);
            reserva.DescricaoQuarto = txbDescQuarto.Text;
            reserva.Status = cbxStatus.Text;
            reserva.DataEntrada = Convert.ToDateTime(dtpDataEntrada.Text);
            reserva.DataSaida = Convert.ToDateTime(dtpDataSaida.Text);

            string mensagem = reserva.Alterar(reserva);
            if (mensagem == "")
            {
                MessageBox.Show("Dados da reserva alterado com sucesso!", "Alteração de dados da reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void CarregaDados_Validated(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            if (txbNumQuarto.Text == "" || txbNomeCliente.Text == "")
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

        private void FrmAlterarStatusReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuReserva frmMenuReserva = new FrmMenuReserva();
            frmMenuReserva.Show();
        }
    }
}
