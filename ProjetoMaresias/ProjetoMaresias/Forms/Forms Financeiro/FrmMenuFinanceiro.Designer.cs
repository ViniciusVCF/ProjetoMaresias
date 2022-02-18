
namespace ProjetoMaresias.Forms.Forms_Financeiro
{
    partial class FrmMenuFinanceiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuFinanceiro));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.imgProdutos = new System.Windows.Forms.PictureBox();
            this.imgFaturamento = new System.Windows.Forms.PictureBox();
            this.imgGastos = new System.Windows.Forms.PictureBox();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFaturamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblProdutos);
            this.pnlMenu.Controls.Add(this.imgProdutos);
            this.pnlMenu.Controls.Add(this.imgFaturamento);
            this.pnlMenu.Controls.Add(this.imgGastos);
            this.pnlMenu.Controls.Add(this.lblFaturamento);
            this.pnlMenu.Controls.Add(this.lblGastos);
            this.pnlMenu.Location = new System.Drawing.Point(93, 191);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(639, 110);
            this.pnlMenu.TabIndex = 10;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdutos.ForeColor = System.Drawing.Color.Peru;
            this.lblProdutos.Location = new System.Drawing.Point(482, 82);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(59, 15);
            this.lblProdutos.TabIndex = 14;
            this.lblProdutos.Text = "Produtos";
            // 
            // imgProdutos
            // 
            this.imgProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgProdutos.Image = ((System.Drawing.Image)(resources.GetObject("imgProdutos.Image")));
            this.imgProdutos.Location = new System.Drawing.Point(471, 20);
            this.imgProdutos.Name = "imgProdutos";
            this.imgProdutos.Size = new System.Drawing.Size(81, 59);
            this.imgProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProdutos.TabIndex = 13;
            this.imgProdutos.TabStop = false;
            this.imgProdutos.Click += new System.EventHandler(this.imgProdutos_Click);
            // 
            // imgFaturamento
            // 
            this.imgFaturamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFaturamento.Image = ((System.Drawing.Image)(resources.GetObject("imgFaturamento.Image")));
            this.imgFaturamento.Location = new System.Drawing.Point(277, 20);
            this.imgFaturamento.Name = "imgFaturamento";
            this.imgFaturamento.Size = new System.Drawing.Size(81, 59);
            this.imgFaturamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFaturamento.TabIndex = 12;
            this.imgFaturamento.TabStop = false;
            this.imgFaturamento.Click += new System.EventHandler(this.imgFaturamento_Click);
            // 
            // imgGastos
            // 
            this.imgGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgGastos.Image = ((System.Drawing.Image)(resources.GetObject("imgGastos.Image")));
            this.imgGastos.Location = new System.Drawing.Point(88, 20);
            this.imgGastos.Name = "imgGastos";
            this.imgGastos.Size = new System.Drawing.Size(81, 59);
            this.imgGastos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGastos.TabIndex = 11;
            this.imgGastos.TabStop = false;
            this.imgGastos.Click += new System.EventHandler(this.imgGastos_Click);
            // 
            // lblFaturamento
            // 
            this.lblFaturamento.AutoSize = true;
            this.lblFaturamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFaturamento.ForeColor = System.Drawing.Color.Peru;
            this.lblFaturamento.Location = new System.Drawing.Point(276, 82);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Size = new System.Drawing.Size(79, 15);
            this.lblFaturamento.TabIndex = 9;
            this.lblFaturamento.Text = "Faturamento";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGastos.ForeColor = System.Drawing.Color.Peru;
            this.lblGastos.Location = new System.Drawing.Point(105, 82);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(47, 15);
            this.lblGastos.TabIndex = 6;
            this.lblGastos.Text = "Gastos";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(314, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(199, 159);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 9;
            this.imgLogo.TabStop = false;
            // 
            // FrmMenuFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 409);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu financeiro";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFaturamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox imgFaturamento;
        private System.Windows.Forms.PictureBox imgGastos;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.PictureBox imgProdutos;
    }
}