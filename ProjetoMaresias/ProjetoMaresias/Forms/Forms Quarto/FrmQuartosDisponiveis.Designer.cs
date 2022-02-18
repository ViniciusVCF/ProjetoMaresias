
namespace ProjetoMaresias.Forms.Forms_Quarto
{
    partial class FrmQuartosDisponiveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuartosDisponiveis));
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.imgLocalizar = new System.Windows.Forms.PictureBox();
            this.dgvDadosQuarto = new System.Windows.Forms.DataGridView();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataEntrada.ForeColor = System.Drawing.Color.Peru;
            this.lblDataEntrada.Location = new System.Drawing.Point(12, 9);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(81, 16);
            this.lblDataEntrada.TabIndex = 29;
            this.lblDataEntrada.Text = "Data entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(12, 29);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(97, 23);
            this.dtpDataEntrada.TabIndex = 28;
            // 
            // imgLocalizar
            // 
            this.imgLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("imgLocalizar.Image")));
            this.imgLocalizar.Location = new System.Drawing.Point(241, 29);
            this.imgLocalizar.Name = "imgLocalizar";
            this.imgLocalizar.Size = new System.Drawing.Size(27, 23);
            this.imgLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLocalizar.TabIndex = 26;
            this.imgLocalizar.TabStop = false;
            this.imgLocalizar.Click += new System.EventHandler(this.imgLocalizar_Click);
            // 
            // dgvDadosQuarto
            // 
            this.dgvDadosQuarto.AllowUserToAddRows = false;
            this.dgvDadosQuarto.AllowUserToDeleteRows = false;
            this.dgvDadosQuarto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDadosQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosQuarto.Location = new System.Drawing.Point(12, 73);
            this.dgvDadosQuarto.Name = "dgvDadosQuarto";
            this.dgvDadosQuarto.ReadOnly = true;
            this.dgvDadosQuarto.RowTemplate.Height = 25;
            this.dgvDadosQuarto.Size = new System.Drawing.Size(760, 478);
            this.dgvDadosQuarto.TabIndex = 24;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(138, 29);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(97, 23);
            this.dtpDataSaida.TabIndex = 30;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataSaida.ForeColor = System.Drawing.Color.Peru;
            this.lblDataSaida.Location = new System.Drawing.Point(138, 9);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(69, 16);
            this.lblDataSaida.TabIndex = 31;
            this.lblDataSaida.Text = "Data saida";
            // 
            // FrmQuartosDisponiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.dtpDataSaida);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.imgLocalizar);
            this.Controls.Add(this.dgvDadosQuarto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuartosDisponiveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disponibilidade de quartos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuartosDisponiveis_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.PictureBox imgLocalizar;
        private System.Windows.Forms.DataGridView dgvDadosQuarto;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Label lblDataSaida;
    }
}