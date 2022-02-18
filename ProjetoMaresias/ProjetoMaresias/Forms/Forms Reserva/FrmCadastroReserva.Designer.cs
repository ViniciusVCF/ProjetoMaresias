
namespace ProjetoMaresias.Forms.Forms_Reserva
{
    partial class FrmCadastroReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroReserva));
            this.pnlDadosReserva = new System.Windows.Forms.Panel();
            this.txbDescQuarto = new System.Windows.Forms.TextBox();
            this.lblDescQuarto = new System.Windows.Forms.Label();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txbNumQuarto = new System.Windows.Forms.TextBox();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.txbCodCliente = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNumQuarto = new System.Windows.Forms.Label();
            this.lblNumReserva = new System.Windows.Forms.Label();
            this.txbNumReserva = new System.Windows.Forms.TextBox();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.eprSemPreenchimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.eprDadoInvalido = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDadosReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDadosReserva
            // 
            this.pnlDadosReserva.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDadosReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDadosReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosReserva.Controls.Add(this.txbDescQuarto);
            this.pnlDadosReserva.Controls.Add(this.lblDescQuarto);
            this.pnlDadosReserva.Controls.Add(this.txbNomeCliente);
            this.pnlDadosReserva.Controls.Add(this.lblNomeCliente);
            this.pnlDadosReserva.Controls.Add(this.cbxStatus);
            this.pnlDadosReserva.Controls.Add(this.txbNumQuarto);
            this.pnlDadosReserva.Controls.Add(this.dtpDataSaida);
            this.pnlDadosReserva.Controls.Add(this.dtpDataEntrada);
            this.pnlDadosReserva.Controls.Add(this.txbCodCliente);
            this.pnlDadosReserva.Controls.Add(this.lblStatus);
            this.pnlDadosReserva.Controls.Add(this.lblNumQuarto);
            this.pnlDadosReserva.Controls.Add(this.lblNumReserva);
            this.pnlDadosReserva.Controls.Add(this.txbNumReserva);
            this.pnlDadosReserva.Controls.Add(this.lblDataSaida);
            this.pnlDadosReserva.Controls.Add(this.lblDataEntrada);
            this.pnlDadosReserva.Controls.Add(this.lblCodCliente);
            this.pnlDadosReserva.ForeColor = System.Drawing.Color.Peru;
            this.pnlDadosReserva.Location = new System.Drawing.Point(29, 28);
            this.pnlDadosReserva.Name = "pnlDadosReserva";
            this.pnlDadosReserva.Size = new System.Drawing.Size(506, 304);
            this.pnlDadosReserva.TabIndex = 2;
            this.pnlDadosReserva.Validated += new System.EventHandler(this.pnlDadosReserva_Validated);
            // 
            // txbDescQuarto
            // 
            this.txbDescQuarto.Enabled = false;
            this.txbDescQuarto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDescQuarto.Location = new System.Drawing.Point(195, 170);
            this.txbDescQuarto.MaxLength = 4;
            this.txbDescQuarto.Name = "txbDescQuarto";
            this.txbDescQuarto.Size = new System.Drawing.Size(259, 21);
            this.txbDescQuarto.TabIndex = 4;
            // 
            // lblDescQuarto
            // 
            this.lblDescQuarto.AutoSize = true;
            this.lblDescQuarto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescQuarto.Location = new System.Drawing.Point(195, 152);
            this.lblDescQuarto.Name = "lblDescQuarto";
            this.lblDescQuarto.Size = new System.Drawing.Size(118, 15);
            this.lblDescQuarto.TabIndex = 50;
            this.lblDescQuarto.Text = "Descrição do quarto";
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomeCliente.Location = new System.Drawing.Point(195, 107);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(259, 21);
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
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Agendado\t"});
            this.cbxStatus.Location = new System.Drawing.Point(55, 230);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(103, 23);
            this.cbxStatus.TabIndex = 5;
            // 
            // txbNumQuarto
            // 
            this.txbNumQuarto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumQuarto.Location = new System.Drawing.Point(55, 170);
            this.txbNumQuarto.MaxLength = 4;
            this.txbNumQuarto.Name = "txbNumQuarto";
            this.txbNumQuarto.Size = new System.Drawing.Size(103, 21);
            this.txbNumQuarto.TabIndex = 3;
            this.txbNumQuarto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbNumQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            this.txbNumQuarto.Validated += new System.EventHandler(this.CarregaDados_Validated);
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(317, 229);
            this.dtpDataSaida.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(90, 23);
            this.dtpDataSaida.TabIndex = 7;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(195, 229);
            this.dtpDataEntrada.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(90, 23);
            this.dtpDataEntrada.TabIndex = 6;
            // 
            // txbCodCliente
            // 
            this.txbCodCliente.Enabled = false;
            this.txbCodCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCodCliente.Location = new System.Drawing.Point(55, 107);
            this.txbCodCliente.Name = "txbCodCliente";
            this.txbCodCliente.Size = new System.Drawing.Size(103, 21);
            this.txbCodCliente.TabIndex = 1;
            this.txbCodCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            this.txbCodCliente.Validated += new System.EventHandler(this.CarregaDados_Validated);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(55, 211);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Status";
            // 
            // lblNumQuarto
            // 
            this.lblNumQuarto.AutoSize = true;
            this.lblNumQuarto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumQuarto.Location = new System.Drawing.Point(55, 152);
            this.lblNumQuarto.Name = "lblNumQuarto";
            this.lblNumQuarto.Size = new System.Drawing.Size(107, 15);
            this.lblNumQuarto.TabIndex = 41;
            this.lblNumQuarto.Text = "Número do quarto";
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
            this.txbNumReserva.Enabled = false;
            this.txbNumReserva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumReserva.Location = new System.Drawing.Point(55, 53);
            this.txbNumReserva.Name = "txbNumReserva";
            this.txbNumReserva.Size = new System.Drawing.Size(103, 21);
            this.txbNumReserva.TabIndex = 0;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataSaida.Location = new System.Drawing.Point(317, 211);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(39, 15);
            this.lblDataSaida.TabIndex = 9;
            this.lblDataSaida.Text = "Saída";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataEntrada.Location = new System.Drawing.Point(195, 211);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(50, 15);
            this.lblDataEntrada.TabIndex = 5;
            this.lblDataEntrada.Text = "Entrada";
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
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(441, 361);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 28);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // eprSemPreenchimento
            // 
            this.eprSemPreenchimento.ContainerControl = this;
            // 
            // eprDadoInvalido
            // 
            this.eprDadoInvalido.ContainerControl = this;
            // 
            // FrmCadastroReserva
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 421);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnlDadosReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastroReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroReserva_FormClosing);
            this.pnlDadosReserva.ResumeLayout(false);
            this.pnlDadosReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDadosReserva;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNumQuarto;
        private System.Windows.Forms.Label lblNumReserva;
        private System.Windows.Forms.TextBox txbNumReserva;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbCodCliente;
        private System.Windows.Forms.TextBox txbNumQuarto;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.TextBox txbDescQuarto;
        private System.Windows.Forms.Label lblDescQuarto;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.ErrorProvider eprSemPreenchimento;
        private System.Windows.Forms.ErrorProvider eprDadoInvalido;
    }
}