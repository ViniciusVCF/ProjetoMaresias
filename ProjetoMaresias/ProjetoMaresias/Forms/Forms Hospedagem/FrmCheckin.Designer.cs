
namespace ProjetoMaresias.Forms.Forms_Hospedagem
{
    partial class FrmCheckin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckin));
            this.pnlDadosCheckin = new System.Windows.Forms.Panel();
            this.lblPrecoHospedagem = new System.Windows.Forms.Label();
            this.txbValorHospedagem = new System.Windows.Forms.TextBox();
            this.imgLocalizar = new System.Windows.Forms.PictureBox();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.mtbHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.mtbHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txbQntdAcompanhante = new System.Windows.Forms.TextBox();
            this.lblNumAcompanhantes = new System.Windows.Forms.Label();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txbDiasEstadia = new System.Windows.Forms.TextBox();
            this.txbCodCliente = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDiasEstadia = new System.Windows.Forms.Label();
            this.lblNumReserva = new System.Windows.Forms.Label();
            this.txbNumReserva = new System.Windows.Forms.TextBox();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.eprSemPreenchimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.eprDadoInvalido = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDadosCheckin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDadosCheckin
            // 
            this.pnlDadosCheckin.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDadosCheckin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDadosCheckin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosCheckin.Controls.Add(this.lblPrecoHospedagem);
            this.pnlDadosCheckin.Controls.Add(this.txbValorHospedagem);
            this.pnlDadosCheckin.Controls.Add(this.imgLocalizar);
            this.pnlDadosCheckin.Controls.Add(this.txbStatus);
            this.pnlDadosCheckin.Controls.Add(this.mtbHoraSaida);
            this.pnlDadosCheckin.Controls.Add(this.mtbHoraEntrada);
            this.pnlDadosCheckin.Controls.Add(this.txbQntdAcompanhante);
            this.pnlDadosCheckin.Controls.Add(this.lblNumAcompanhantes);
            this.pnlDadosCheckin.Controls.Add(this.txbNomeCliente);
            this.pnlDadosCheckin.Controls.Add(this.lblNomeCliente);
            this.pnlDadosCheckin.Controls.Add(this.txbDiasEstadia);
            this.pnlDadosCheckin.Controls.Add(this.txbCodCliente);
            this.pnlDadosCheckin.Controls.Add(this.lblStatus);
            this.pnlDadosCheckin.Controls.Add(this.lblDiasEstadia);
            this.pnlDadosCheckin.Controls.Add(this.lblNumReserva);
            this.pnlDadosCheckin.Controls.Add(this.txbNumReserva);
            this.pnlDadosCheckin.Controls.Add(this.lblHoraSaida);
            this.pnlDadosCheckin.Controls.Add(this.lblHoraEntrada);
            this.pnlDadosCheckin.Controls.Add(this.lblCodCliente);
            this.pnlDadosCheckin.ForeColor = System.Drawing.Color.Peru;
            this.pnlDadosCheckin.Location = new System.Drawing.Point(29, 28);
            this.pnlDadosCheckin.Name = "pnlDadosCheckin";
            this.pnlDadosCheckin.Size = new System.Drawing.Size(506, 296);
            this.pnlDadosCheckin.TabIndex = 3;
            // 
            // lblPrecoHospedagem
            // 
            this.lblPrecoHospedagem.AutoSize = true;
            this.lblPrecoHospedagem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoHospedagem.Location = new System.Drawing.Point(330, 148);
            this.lblPrecoHospedagem.Name = "lblPrecoHospedagem";
            this.lblPrecoHospedagem.Size = new System.Drawing.Size(111, 15);
            this.lblPrecoHospedagem.TabIndex = 74;
            this.lblPrecoHospedagem.Text = "Valor hospedagem";
            // 
            // txbValorHospedagem
            // 
            this.txbValorHospedagem.Enabled = false;
            this.txbValorHospedagem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbValorHospedagem.Location = new System.Drawing.Point(330, 166);
            this.txbValorHospedagem.Name = "txbValorHospedagem";
            this.txbValorHospedagem.Size = new System.Drawing.Size(113, 21);
            this.txbValorHospedagem.TabIndex = 73;
            // 
            // imgLocalizar
            // 
            this.imgLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("imgLocalizar.Image")));
            this.imgLocalizar.Location = new System.Drawing.Point(164, 53);
            this.imgLocalizar.Name = "imgLocalizar";
            this.imgLocalizar.Size = new System.Drawing.Size(23, 21);
            this.imgLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLocalizar.TabIndex = 72;
            this.imgLocalizar.TabStop = false;
            this.imgLocalizar.Click += new System.EventHandler(this.imgLocalizar_Click);
            // 
            // txbStatus
            // 
            this.txbStatus.Enabled = false;
            this.txbStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbStatus.Location = new System.Drawing.Point(55, 224);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(103, 21);
            this.txbStatus.TabIndex = 53;
            this.txbStatus.Text = "Iniciado";
            // 
            // mtbHoraSaida
            // 
            this.mtbHoraSaida.Enabled = false;
            this.mtbHoraSaida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbHoraSaida.Location = new System.Drawing.Point(274, 223);
            this.mtbHoraSaida.Mask = "00:00";
            this.mtbHoraSaida.Name = "mtbHoraSaida";
            this.mtbHoraSaida.Size = new System.Drawing.Size(50, 21);
            this.mtbHoraSaida.TabIndex = 52;
            this.mtbHoraSaida.ValidatingType = typeof(System.DateTime);
            // 
            // mtbHoraEntrada
            // 
            this.mtbHoraEntrada.Enabled = false;
            this.mtbHoraEntrada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbHoraEntrada.Location = new System.Drawing.Point(195, 223);
            this.mtbHoraEntrada.Mask = "00:00";
            this.mtbHoraEntrada.Name = "mtbHoraEntrada";
            this.mtbHoraEntrada.Size = new System.Drawing.Size(50, 21);
            this.mtbHoraEntrada.TabIndex = 51;
            this.mtbHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txbQntdAcompanhante
            // 
            this.txbQntdAcompanhante.Enabled = false;
            this.txbQntdAcompanhante.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbQntdAcompanhante.Location = new System.Drawing.Point(195, 166);
            this.txbQntdAcompanhante.MaxLength = 1;
            this.txbQntdAcompanhante.Name = "txbQntdAcompanhante";
            this.txbQntdAcompanhante.Size = new System.Drawing.Size(97, 21);
            this.txbQntdAcompanhante.TabIndex = 4;
            this.txbQntdAcompanhante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbQntdAcompanhante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            // 
            // lblNumAcompanhantes
            // 
            this.lblNumAcompanhantes.AutoSize = true;
            this.lblNumAcompanhantes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumAcompanhantes.Location = new System.Drawing.Point(195, 148);
            this.lblNumAcompanhantes.Name = "lblNumAcompanhantes";
            this.lblNumAcompanhantes.Size = new System.Drawing.Size(97, 15);
            this.lblNumAcompanhantes.TabIndex = 50;
            this.lblNumAcompanhantes.Text = "Acompanhantes";
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Enabled = false;
            this.txbNomeCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomeCliente.Location = new System.Drawing.Point(195, 107);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(248, 21);
            this.txbNomeCliente.TabIndex = 2;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCliente.Location = new System.Drawing.Point(195, 89);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(97, 15);
            this.lblNomeCliente.TabIndex = 48;
            this.lblNomeCliente.Text = "Nome do cliente";
            // 
            // txbDiasEstadia
            // 
            this.txbDiasEstadia.Enabled = false;
            this.txbDiasEstadia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDiasEstadia.Location = new System.Drawing.Point(55, 166);
            this.txbDiasEstadia.Name = "txbDiasEstadia";
            this.txbDiasEstadia.Size = new System.Drawing.Size(103, 21);
            this.txbDiasEstadia.TabIndex = 3;
            // 
            // txbCodCliente
            // 
            this.txbCodCliente.Enabled = false;
            this.txbCodCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCodCliente.Location = new System.Drawing.Point(55, 107);
            this.txbCodCliente.Name = "txbCodCliente";
            this.txbCodCliente.Size = new System.Drawing.Size(103, 21);
            this.txbCodCliente.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(55, 205);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Status";
            // 
            // lblDiasEstadia
            // 
            this.lblDiasEstadia.AutoSize = true;
            this.lblDiasEstadia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiasEstadia.Location = new System.Drawing.Point(55, 148);
            this.lblDiasEstadia.Name = "lblDiasEstadia";
            this.lblDiasEstadia.Size = new System.Drawing.Size(77, 15);
            this.lblDiasEstadia.TabIndex = 41;
            this.lblDiasEstadia.Text = "Dias estadia";
            // 
            // lblNumReserva
            // 
            this.lblNumReserva.AutoSize = true;
            this.lblNumReserva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumReserva.Location = new System.Drawing.Point(55, 35);
            this.lblNumReserva.Name = "lblNumReserva";
            this.lblNumReserva.Size = new System.Drawing.Size(113, 15);
            this.lblNumReserva.TabIndex = 12;
            this.lblNumReserva.Text = "Número da reserva";
            // 
            // txbNumReserva
            // 
            this.txbNumReserva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumReserva.Location = new System.Drawing.Point(55, 53);
            this.txbNumReserva.Name = "txbNumReserva";
            this.txbNumReserva.Size = new System.Drawing.Size(103, 21);
            this.txbNumReserva.TabIndex = 0;
            this.txbNumReserva.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbNumReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraSaida.Location = new System.Drawing.Point(274, 205);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(39, 15);
            this.lblHoraSaida.TabIndex = 9;
            this.lblHoraSaida.Text = "Saída";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraEntrada.Location = new System.Drawing.Point(195, 205);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(50, 15);
            this.lblHoraEntrada.TabIndex = 5;
            this.lblHoraEntrada.Text = "Entrada";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodCliente.Location = new System.Drawing.Point(55, 89);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(103, 15);
            this.lblCodCliente.TabIndex = 1;
            this.lblCodCliente.Text = "Código do cliente";
            // 
            // btnCheckin
            // 
            this.btnCheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckin.Location = new System.Drawing.Point(441, 350);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(94, 28);
            this.btnCheckin.TabIndex = 9;
            this.btnCheckin.Text = "Check-in";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // eprSemPreenchimento
            // 
            this.eprSemPreenchimento.ContainerControl = this;
            // 
            // eprDadoInvalido
            // 
            this.eprDadoInvalido.ContainerControl = this;
            // 
            // FrmCheckin
            // 
            this.AcceptButton = this.btnCheckin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 402);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.pnlDadosCheckin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCheckin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCheckin_FormClosing);
            this.pnlDadosCheckin.ResumeLayout(false);
            this.pnlDadosCheckin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDadosCheckin;
        private System.Windows.Forms.TextBox txbQntdAcompanhante;
        private System.Windows.Forms.Label lblNumAcompanhantes;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txbDiasEstadia;
        private System.Windows.Forms.TextBox txbCodCliente;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDiasEstadia;
        private System.Windows.Forms.Label lblNumReserva;
        private System.Windows.Forms.TextBox txbNumReserva;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.MaskedTextBox mtbHoraSaida;
        private System.Windows.Forms.MaskedTextBox mtbHoraEntrada;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.PictureBox imgLocalizar;
        private System.Windows.Forms.Label lblPrecoHospedagem;
        private System.Windows.Forms.TextBox txbValorHospedagem;
        private System.Windows.Forms.ErrorProvider eprSemPreenchimento;
        private System.Windows.Forms.ErrorProvider eprDadoInvalido;
    }
}