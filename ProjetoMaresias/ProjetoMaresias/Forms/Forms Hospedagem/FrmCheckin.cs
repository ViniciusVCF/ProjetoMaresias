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
    public partial class FrmCheckin : Form
    {
        public FrmCheckin()
        {
            InitializeComponent();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            if (txbNumReserva.Text != "")
            {
                Hospedagem hospedagem = new Hospedagem();
                hospedagem = hospedagem.DadosCadastro(Convert.ToInt32(txbNumReserva.Text));
                if (hospedagem.NumeroReserva != 0)
                {
                    txbNumReserva.Enabled = false;
                    txbCodCliente.Text = hospedagem.IdCliente.ToString();
                    txbNomeCliente.Text = hospedagem.NomeCliente;
                    txbDiasEstadia.Text = hospedagem.DiasEstadia.ToString();
                    txbQntdAcompanhante.Enabled = true;
                    txbValorHospedagem.Text = hospedagem.ValorHospedagem.ToString("F2");
                    mtbHoraEntrada.Text = DateTime.Now.ToString("HH/mm");
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

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosCheckin))
            {
                Hospedagem hospedagem = new Hospedagem();
                hospedagem.IdCliente = Convert.ToInt32(txbCodCliente.Text);
                hospedagem.NomeCliente = txbNomeCliente.Text;
                hospedagem.NumeroReserva = Convert.ToInt32(txbNumReserva.Text);
                hospedagem.DiasEstadia = Convert.ToInt32(txbDiasEstadia.Text);
                hospedagem.IdProduto = 0;
                hospedagem.DescricaoProduto = "";
                hospedagem.ValorProduto = 0;
                hospedagem.QuantidadeConsumo = 0;
                hospedagem.ValorHospedagem = Convert.ToDouble(txbValorHospedagem.Text);
                if (txbQntdAcompanhante.Text == "")
                {
                    hospedagem.QuantidadeAcompanhante = 0;
                }
                else
                {
                    hospedagem.QuantidadeAcompanhante = Convert.ToInt32(txbQntdAcompanhante.Text);
                }
                hospedagem.Checkin = TimeSpan.Parse(mtbHoraEntrada.Text);
                hospedagem.Checkout = TimeSpan.Zero;
                hospedagem.Status = txbStatus.Text;

                string mensagem = hospedagem.CadastroCheckin(hospedagem);
                if (mensagem == "")
                {
                    MessageBox.Show("Check-in realizado com sucesso!", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Existem informações sem preenchimento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCheckin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuHospedagem frmMenuHospedagem = new FrmMenuHospedagem();
            frmMenuHospedagem.Show();
        }
    }
}
