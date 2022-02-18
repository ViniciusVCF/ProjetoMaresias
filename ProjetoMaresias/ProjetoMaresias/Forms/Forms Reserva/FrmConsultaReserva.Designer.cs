
namespace ProjetoMaresias.Forms.Forms_Reserva
{
    partial class FrmConsultaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaReserva));
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.imgLocalizar = new System.Windows.Forms.PictureBox();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.dgvDadosReserva = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.Peru;
            this.lblStatus.Location = new System.Drawing.Point(303, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 16);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Agendado",
            "Finalizado",
            "Cancelado",
            "Todos"});
            this.cbxStatus.Location = new System.Drawing.Point(303, 29);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(102, 23);
            this.cbxStatus.TabIndex = 15;
            // 
            // imgLocalizar
            // 
            this.imgLocalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("imgLocalizar.Image")));
            this.imgLocalizar.Location = new System.Drawing.Point(411, 29);
            this.imgLocalizar.Name = "imgLocalizar";
            this.imgLocalizar.Size = new System.Drawing.Size(27, 23);
            this.imgLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLocalizar.TabIndex = 18;
            this.imgLocalizar.TabStop = false;
            this.imgLocalizar.Click += new System.EventHandler(this.imgLocalizar_Click);
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Location = new System.Drawing.Point(12, 29);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(268, 23);
            this.txbNomeCliente.TabIndex = 14;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.Peru;
            this.lblNomeCliente.Location = new System.Drawing.Point(12, 10);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(101, 16);
            this.lblNomeCliente.TabIndex = 17;
            this.lblNomeCliente.Text = "Nome do cliente";
            // 
            // dgvDadosReserva
            // 
            this.dgvDadosReserva.AllowUserToAddRows = false;
            this.dgvDadosReserva.AllowUserToDeleteRows = false;
            this.dgvDadosReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDadosReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosReserva.Location = new System.Drawing.Point(12, 72);
            this.dgvDadosReserva.Name = "dgvDadosReserva";
            this.dgvDadosReserva.ReadOnly = true;
            this.dgvDadosReserva.RowTemplate.Height = 25;
            this.dgvDadosReserva.Size = new System.Drawing.Size(760, 478);
            this.dgvDadosReserva.TabIndex = 16;
            // 
            // FrmConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.imgLocalizar);
            this.Controls.Add(this.txbNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.dgvDadosReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de reservas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultaReserva_FormClosing);
            this.Load += new System.EventHandler(this.FrmConsultaReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.PictureBox imgLocalizar;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.DataGridView dgvDadosReserva;
    }
}