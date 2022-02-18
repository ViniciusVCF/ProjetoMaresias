using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMaresias.Forms.Forms_Gastos
{
    public partial class FrmMenuGastos : Form
    {
        public FrmMenuGastos()
        {
            InitializeComponent();
        }

        private void imgProdutos_Click(object sender, EventArgs e)
        {
            FrmCompras frmCompras = new FrmCompras();
            frmCompras.Show();
            this.Close();
        }

        private void imgRecepcao_Click(object sender, EventArgs e)
        {
            FrmRelatorio frmRelatorio = new FrmRelatorio();
            frmRelatorio.Show();
            this.Close();
        }
    }
}
