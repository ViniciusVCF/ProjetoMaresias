
namespace ProjetoMaresias.Forms.Forms_Produto
{
    partial class FrmConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaProduto));
            this.imgLocalizar = new System.Windows.Forms.PictureBox();
            this.txbDescProduto = new System.Windows.Forms.TextBox();
            this.lblDescProduto = new System.Windows.Forms.Label();
            this.dgvDadosProduto = new System.Windows.Forms.DataGridView();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLocalizar
            // 
            this.imgLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("imgLocalizar.Image")));
            this.imgLocalizar.Location = new System.Drawing.Point(335, 29);
            this.imgLocalizar.Name = "imgLocalizar";
            this.imgLocalizar.Size = new System.Drawing.Size(27, 23);
            this.imgLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLocalizar.TabIndex = 16;
            this.imgLocalizar.TabStop = false;
            this.imgLocalizar.Click += new System.EventHandler(this.imgLocalizar_Click);
            // 
            // txbDescProduto
            // 
            this.txbDescProduto.Location = new System.Drawing.Point(12, 29);
            this.txbDescProduto.Name = "txbDescProduto";
            this.txbDescProduto.Size = new System.Drawing.Size(268, 23);
            this.txbDescProduto.TabIndex = 13;
            // 
            // lblDescProduto
            // 
            this.lblDescProduto.AutoSize = true;
            this.lblDescProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescProduto.ForeColor = System.Drawing.Color.Peru;
            this.lblDescProduto.Location = new System.Drawing.Point(12, 10);
            this.lblDescProduto.Name = "lblDescProduto";
            this.lblDescProduto.Size = new System.Drawing.Size(130, 16);
            this.lblDescProduto.TabIndex = 15;
            this.lblDescProduto.Text = "Descrição do produto";
            // 
            // dgvDadosProduto
            // 
            this.dgvDadosProduto.AllowUserToAddRows = false;
            this.dgvDadosProduto.AllowUserToDeleteRows = false;
            this.dgvDadosProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosProduto.Location = new System.Drawing.Point(12, 72);
            this.dgvDadosProduto.Name = "dgvDadosProduto";
            this.dgvDadosProduto.ReadOnly = true;
            this.dgvDadosProduto.RowTemplate.Height = 25;
            this.dgvDadosProduto.Size = new System.Drawing.Size(760, 478);
            this.dgvDadosProduto.TabIndex = 14;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(287, 28);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(42, 23);
            this.cbxStatus.TabIndex = 17;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.Peru;
            this.lblStatus.Location = new System.Drawing.Point(284, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 16);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // FrmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.imgLocalizar);
            this.Controls.Add(this.txbDescProduto);
            this.Controls.Add(this.lblDescProduto);
            this.Controls.Add(this.dgvDadosProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultaProduto_FormClosing);
            this.Load += new System.EventHandler(this.FrmConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLocalizar;
        private System.Windows.Forms.TextBox txbDescProduto;
        private System.Windows.Forms.Label lblDescProduto;
        private System.Windows.Forms.DataGridView dgvDadosProduto;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}