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
    public partial class FrmMenuHospedagem : Form
    {
        public FrmMenuHospedagem()
        {
            InitializeComponent();
        }

        private void imgCheckin_Click(object sender, EventArgs e)
        {
            FrmCheckin frmCheckin = new FrmCheckin();
            frmCheckin.Show();
            this.Close();
        }

        private void imgConsumo_Click(object sender, EventArgs e)
        {
            FrmIncluirConsumo frmIncluirConsumo = new FrmIncluirConsumo();
            frmIncluirConsumo.Show();
            this.Close();
        }

        private void imgCheckout_Click(object sender, EventArgs e)
        {
            FrmCheckout frmCheckout = new FrmCheckout();
            frmCheckout.Show();
            this.Close();
        }
    }
}
