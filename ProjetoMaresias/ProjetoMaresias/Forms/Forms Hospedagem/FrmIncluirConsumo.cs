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
    public partial class FrmIncluirConsumo : Form
    {
        public FrmIncluirConsumo()
        {
            InitializeComponent();
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
                    cbxDescProduto.DataSource = hospedagem.ProdutosDisponiveis();
                    cbxDescProduto.ValueMember = "Ds_Produto";
                    cbxDescProduto.SelectedItem = "";
                    cbxDescProduto.Refresh();
                    cbxDescProduto.SelectedIndex = -1;

                    if (hospedagem.Status != "Finalizado")
                    {
                        cbxDescProduto.Enabled = true;
                        txbQuantidade.Enabled = true;
                        btnIncluir.Enabled = true;
                        btnLimpar.Enabled = true;
                    }
                        
                    dgvConsumo.DataSource = hospedagem.ConsultaConsumo(hospedagem.NumeroReserva);
                    txbValorHospedagem.Text = hospedagem.ValorHospedagem.ToString("F2");
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!Validacao.DadosVazios(eprSemPreenchimento, pnlDadosConsumo))
            {
                if (!Validacao.DadosInvalidos(eprSemPreenchimento, pnlDadosConsumo))
                {
                    Hospedagem hospedagem = new Hospedagem();
                    hospedagem.NumeroReserva = Convert.ToInt32(txbNumReserva.Text);
                    hospedagem.IdProduto = Convert.ToInt32(txbCodProduto.Text);
                    hospedagem.DescricaoProduto = cbxDescProduto.Text;
                    hospedagem.ValorProduto = Convert.ToDouble(txbPrecoUnitario.Text);
                    hospedagem.QuantidadeConsumo = Convert.ToInt32(txbQuantidade.Text);
                    hospedagem.ValorHospedagem = Convert.ToDouble(txbValorHospedagem.Text);

                    string mensagem = hospedagem.IncluiConsumo(hospedagem);
                    if (mensagem == "")
                    {
                        MessageBox.Show("Produto incluído com sucesso!", "Inclusão de produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvConsumo.DataSource = hospedagem.ConsultaConsumo(hospedagem.NumeroReserva);
                    }
                    else
                    {
                        MessageBox.Show(mensagem, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Existem dados incorretos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existem informações sem preenchimento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnLimpar_Click(sender, e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCodProduto.Text = "";
            txbPrecoTotal.Text = "";
            txbPrecoUnitario.Text = "";
            txbQuantidade.Text = "1";
            cbxDescProduto.SelectedIndex = -1;
        }

        private void cbxDescProduto_TextChanged(object sender, EventArgs e)
        {
            Hospedagem hospedagem = new Hospedagem();
            Produto produto = new Produto();

            hospedagem = hospedagem.CarregarDados(Convert.ToInt32(txbNumReserva.Text));
            produto = produto.ProcuraProduto(cbxDescProduto.Text);
            txbCodProduto.Text = produto.IdProduto.ToString();
            txbPrecoUnitario.Text = produto.Preco.ToString("F2");
            double precoTotal = Convert.ToInt32(txbQuantidade.Text) * Convert.ToDouble(txbPrecoUnitario.Text);
            if(precoTotal == 0)
            {
                txbPrecoTotal.Text = txbPrecoUnitario.Text;
            }
            else
            {
                txbPrecoTotal.Text = precoTotal.ToString("F2");
            }
            txbValorHospedagem.Text = (Convert.ToDouble(txbPrecoTotal.Text) + hospedagem.ValorHospedagem).ToString("F2");
        }

        private void pnlDadosConsumo_Validated(object sender, EventArgs e)
        {
            eprDadoInvalido.Clear();
            if (Convert.ToInt32(txbQuantidade.Text) <= 0)
            {
                eprDadoInvalido.SetError(txbQuantidade, "Quantidade deve ser maior que 0");
            }
        }

        private void FrmIncluirConsumo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenuHospedagem frmMenuHospedagem = new FrmMenuHospedagem();
            frmMenuHospedagem.Show();
        }

        private void txbQuantidade_Leave(object sender, EventArgs e)
        {
            if(txbQuantidade.Text == "")
            {
                txbQuantidade.Text = "1";
            }
        }

        private void txbQuantidade_TextChanged(object sender, EventArgs e)
        {
            double total;
            if (txbPrecoUnitario.Text == "")
            {
                total = 0.0;
            }
            else
            {
                total = 0 + (Convert.ToDouble(txbPrecoUnitario.Text) * Convert.ToInt32(txbQuantidade.Text));
            }
            txbPrecoTotal.Text = total.ToString("F2");
        }
    }
}
