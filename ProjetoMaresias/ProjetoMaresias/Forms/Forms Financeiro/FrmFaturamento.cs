using ProjetoMaresias.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_Financeiro
{
    public partial class FrmFaturamento : Form
    {
        public FrmFaturamento()
        {
            InitializeComponent();
        }

        private void imgLocalizar_Click(object sender, EventArgs e)
        {
            Hospedagem hospedagem = new Hospedagem();

            dgvDadosFaturamento.DataSource = hospedagem.Faturamento(Convert.ToDateTime(dtpDataInicio.Text), Convert.ToDateTime(dtpDataFinal.Text));
        }
    }
}
