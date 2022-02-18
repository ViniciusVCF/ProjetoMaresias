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

namespace ProjetoMaresias.Forms.Forms_Hospedagem
{
    public partial class FrmCheckout : Form
    {
        public FrmCheckout()
        {
            InitializeComponent();
        }

        private void FrmCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuHospedagem frmMenuHospedagem = new FrmMenuHospedagem();
            frmMenuHospedagem.Show();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            if (txbNumReserva.Text != "")
            {
                Hospedagem hospedagem = new Hospedagem();
                hospedagem = hospedagem.CarregarDados(Convert.ToInt32(txbNumReserva.Text));
                if (hospedagem.NumeroReserva != 0)
                {
                    txbNumReserva.Enabled = false;
                    txbCodCliente.Text = hospedagem.IdCliente.ToString();
                    txbNomeCliente.Text = hospedagem.NomeCliente;
                    txbDiasEstadia.Text = hospedagem.DiasEstadia.ToString();
                    txbValorHospedagem.Text = hospedagem.ValorHospedagem.ToString("F2");
                    txbQntdAcompanhante.Text = hospedagem.QuantidadeAcompanhante.ToString();
                    mtbHoraEntrada.Text = hospedagem.Checkin.ToString();
                    mtbHoraSaida.Text = DateTime.Now.ToString("HH/mm");
                    dgvConsumo.DataSource = hospedagem.ConsultaConsumo(hospedagem.NumeroReserva);

                    if(hospedagem.Status != "Finalizado")
                    {
                        btnCheckout.Enabled = true;
                    } 
                }
                else
                {
                    MessageBox.Show("Número de reserva inválido!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Número de reserva não informado!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Hospedagem hospedagem = new Hospedagem();
            hospedagem.NumeroReserva = Convert.ToInt32(txbNumReserva.Text);
            hospedagem.Checkout = TimeSpan.Parse(mtbHoraSaida.Text);
            hospedagem.Status = txbStatus.Text;

            string mensagem = hospedagem.CadastroCheckout(hospedagem);
            if (mensagem == "")
            {
                MessageBox.Show("Check-out realizado com sucesso!", "Check-out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
