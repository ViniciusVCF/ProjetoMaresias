
namespace ProjetoMaresias.Forms.Forms_Gastos
{
    partial class FrmMenuGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuGastos));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblCompras = new System.Windows.Forms.Label();
            this.imgProdutos = new System.Windows.Forms.PictureBox();
            this.imgRecepcao = new System.Windows.Forms.PictureBox();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecepcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblCompras);
            this.pnlMenu.Controls.Add(this.imgProdutos);
            this.pnlMenu.Controls.Add(this.imgRecepcao);
            this.pnlMenu.Controls.Add(this.lblRelatorio);
            this.pnlMenu.Location = new System.Drawing.Point(93, 191);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(639, 110);
            this.pnlMenu.TabIndex = 12;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCompras.ForeColor = System.Drawing.Color.Peru;
            this.lblCompras.Location = new System.Drawing.Point(412, 82);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(59, 15);
            this.lblCompras.TabIndex = 14;
            this.lblCompras.Text = "Compras";
            // 
            // imgProdutos
            // 
            this.imgProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgProdutos.Image = ((System.Drawing.Image)(resources.GetObject("imgProdutos.Image")));
            this.imgProdutos.Location = new System.Drawing.Point(401, 20);
            this.imgProdutos.Name = "imgProdutos";
            this.imgProdutos.Size = new System.Drawing.Size(81, 59);
            this.imgProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProdutos.TabIndex = 13;
            this.imgProdutos.TabStop = false;
            this.imgProdutos.Click += new System.EventHandler(this.imgProdutos_Click);
            // 
            // imgRecepcao
            // 
            this.imgRecepcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgRecepcao.Image = ((System.Drawing.Image)(resources.GetObject("imgRecepcao.Image")));
            this.imgRecepcao.Location = new System.Drawing.Point(144, 20);
            this.imgRecepcao.Name = "imgRecepcao";
            this.imgRecepcao.Size = new System.Drawing.Size(81, 59);
            this.imgRecepcao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRecepcao.TabIndex = 11;
            this.imgRecepcao.TabStop = false;
            this.imgRecepcao.Click += new System.EventHandler(this.imgRecepcao_Click);
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRelatorio.ForeColor = System.Drawing.Color.Peru;
            this.lblRelatorio.Location = new System.Drawing.Point(156, 82);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(58, 15);
            this.lblRelatorio.TabIndex = 6;
            this.lblRelatorio.Text = "Relatório";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(314, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(199, 159);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 11;
            this.imgLogo.TabStop = false;
            // 
            // FrmMenuGastos
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
            this.Name = "FrmMenuGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu gastos";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecepcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.PictureBox imgProdutos;
        private System.Windows.Forms.PictureBox imgRecepcao;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}