
namespace ProjetoMaresias.Forms.Forms_Quarto
{
    partial class FrmConsultaQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaQuarto));
            this.imgLocalizar = new System.Windows.Forms.PictureBox();
            this.txbDescQuarto = new System.Windows.Forms.TextBox();
            this.lblDescQuarto = new System.Windows.Forms.Label();
            this.dgvDadosQuarto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLocalizar
            // 
            this.imgLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("imgLocalizar.Image")));
            this.imgLocalizar.Location = new System.Drawing.Point(286, 29);
            this.imgLocalizar.Name = "imgLocalizar";
            this.imgLocalizar.Size = new System.Drawing.Size(27, 23);
            this.imgLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLocalizar.TabIndex = 12;
            this.imgLocalizar.TabStop = false;
            this.imgLocalizar.Click += new System.EventHandler(this.imgLocalizar_Click);
            // 
            // txbDescQuarto
            // 
            this.txbDescQuarto.Location = new System.Drawing.Point(12, 29);
            this.txbDescQuarto.Name = "txbDescQuarto";
            this.txbDescQuarto.Size = new System.Drawing.Size(268, 23);
            this.txbDescQuarto.TabIndex = 8;
            // 
            // lblDescQuarto
            // 
            this.lblDescQuarto.AutoSize = true;
            this.lblDescQuarto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescQuarto.ForeColor = System.Drawing.Color.Peru;
            this.lblDescQuarto.Location = new System.Drawing.Point(12, 10);
            this.lblDescQuarto.Name = "lblDescQuarto";
            this.lblDescQuarto.Size = new System.Drawing.Size(123, 16);
            this.lblDescQuarto.TabIndex = 11;
            this.lblDescQuarto.Text = "Descrição do quarto";
            // 
            // dgvDadosQuarto
            // 
            this.dgvDadosQuarto.AllowUserToAddRows = false;
            this.dgvDadosQuarto.AllowUserToDeleteRows = false;
            this.dgvDadosQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDadosQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosQuarto.Location = new System.Drawing.Point(12, 72);
            this.dgvDadosQuarto.Name = "dgvDadosQuarto";
            this.dgvDadosQuarto.ReadOnly = true;
            this.dgvDadosQuarto.RowTemplate.Height = 25;
            this.dgvDadosQuarto.Size = new System.Drawing.Size(760, 478);
            this.dgvDadosQuarto.TabIndex = 10;
            // 
            // FrmConsultaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.imgLocalizar);
            this.Controls.Add(this.txbDescQuarto);
            this.Controls.Add(this.lblDescQuarto);
            this.Controls.Add(this.dgvDadosQuarto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de quartos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultaQuarto_FormClosing);
            this.Load += new System.EventHandler(this.FrmConsultaQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLocalizar;
        private System.Windows.Forms.TextBox txbDescQuarto;
        private System.Windows.Forms.Label lblDescQuarto;
        private System.Windows.Forms.DataGridView dgvDadosQuarto;
    }
}