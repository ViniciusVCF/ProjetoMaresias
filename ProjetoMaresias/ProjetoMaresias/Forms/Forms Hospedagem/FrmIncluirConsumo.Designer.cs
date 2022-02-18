
namespace ProjetoMaresias.Forms.Forms_Hospedagem
{
    partial class FrmIncluirConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncluirConsumo));
            this.pnlDadosConsumo = new System.Windows.Forms.Panel();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.cbxDescProduto = new System.Windows.Forms.ComboBox();
            this.txbPrecoTotal = new System.Windows.Forms.TextBox();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.lblPrecoHospedagem = new System.Windows.Forms.Label();
            this.txbValorHospedagem = new System.Windows.Forms.TextBox();
            this.imgLocalizar = new System.Windows.Forms.PictureBox();
            this.lblDescProduto = new System.Windows.Forms.Label();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.lblNumReserva = new System.Windows.Forms.Label();
            this.txbNumReserva = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.dgvConsumo = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.eprSemPreenchimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.eprDadoInvalido = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlDadosConsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDadosConsumo
            // 
            this.pnlDadosConsumo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDadosConsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDadosConsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosConsumo.Controls.Add(this.txbQuantidade);
            this.pnlDadosConsumo.Controls.Add(this.lblQuantidade);
            this.pnlDadosConsumo.Controls.Add(this.txbPrecoUnitario);
            this.pnlDadosConsumo.Controls.Add(this.lblPreco);
            this.pnlDadosConsumo.Controls.Add(this.cbxDescProduto);
            this.pnlDadosConsumo.Controls.Add(this.txbPrecoTotal);
            this.pnlDadosConsumo.Controls.Add(this.lblPrecoTotal);
            this.pnlDadosConsumo.Controls.Add(this.lblPrecoHospedagem);
            this.pnlDadosConsumo.Controls.Add(this.txbValorHospedagem);
            this.pnlDadosConsumo.Controls.Add(this.imgLocalizar);
            this.pnlDadosConsumo.Controls.Add(this.lblDescProduto);
            this.pnlDadosConsumo.Controls.Add(this.txbCodProduto);
            this.pnlDadosConsumo.Controls.Add(this.lblNumReserva);
            this.pnlDadosConsumo.Controls.Add(this.txbNumReserva);
            this.pnlDadosConsumo.Controls.Add(this.lblCodProduto);
            this.pnlDadosConsumo.ForeColor = System.Drawing.Color.Peru;
            this.pnlDadosConsumo.Location = new System.Drawing.Point(30, 27);
            this.pnlDadosConsumo.Name = "pnlDadosConsumo";
            this.pnlDadosConsumo.Size = new System.Drawing.Size(622, 232);
            this.pnlDadosConsumo.TabIndex = 4;
            this.pnlDadosConsumo.Validated += new System.EventHandler(this.pnlDadosConsumo_Validated);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Enabled = false;
            this.txbQuantidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbQuantidade.Location = new System.Drawing.Point(55, 105);
            this.txbQuantidade.MaxLength = 2;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(103, 21);
            this.txbQuantidade.TabIndex = 80;
            this.txbQuantidade.Text = "1";
            this.txbQuantidade.TextChanged += new System.EventHandler(this.txbQuantidade_TextChanged);
            this.txbQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            this.txbQuantidade.Leave += new System.EventHandler(this.txbQuantidade_Leave);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(55, 87);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(71, 15);
            this.lblQuantidade.TabIndex = 81;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txbPrecoUnitario
            // 
            this.txbPrecoUnitario.Enabled = false;
            this.txbPrecoUnitario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPrecoUnitario.Location = new System.Drawing.Point(55, 166);
            this.txbPrecoUnitario.Name = "txbPrecoUnitario";
            this.txbPrecoUnitario.Size = new System.Drawing.Size(97, 21);
            this.txbPrecoUnitario.TabIndex = 78;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.Location = new System.Drawing.Point(55, 148);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(83, 15);
            this.lblPreco.TabIndex = 79;
            this.lblPreco.Text = "Preço unitário";
            // 
            // cbxDescProduto
            // 
            this.cbxDescProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDescProduto.Enabled = false;
            this.cbxDescProduto.FormattingEnabled = true;
            this.cbxDescProduto.Location = new System.Drawing.Point(335, 106);
            this.cbxDescProduto.Name = "cbxDescProduto";
            this.cbxDescProduto.Size = new System.Drawing.Size(248, 23);
            this.cbxDescProduto.TabIndex = 77;
            this.cbxDescProduto.TextChanged += new System.EventHandler(this.cbxDescProduto_TextChanged);
            // 
            // txbPrecoTotal
            // 
            this.txbPrecoTotal.Enabled = false;
            this.txbPrecoTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPrecoTotal.Location = new System.Drawing.Point(195, 166);
            this.txbPrecoTotal.Name = "txbPrecoTotal";
            this.txbPrecoTotal.Size = new System.Drawing.Size(97, 21);
            this.txbPrecoTotal.TabIndex = 75;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoTotal.Location = new System.Drawing.Point(195, 148);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(65, 15);
            this.lblPrecoTotal.TabIndex = 76;
            this.lblPrecoTotal.Text = "Preço total";
            // 
            // lblPrecoHospedagem
            // 
            this.lblPrecoHospedagem.AutoSize = true;
            this.lblPrecoHospedagem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoHospedagem.Location = new System.Drawing.Point(332, 148);
            this.lblPrecoHospedagem.Name = "lblPrecoHospedagem";
            this.lblPrecoHospedagem.Size = new System.Drawing.Size(111, 15);
            this.lblPrecoHospedagem.TabIndex = 74;
            this.lblPrecoHospedagem.Text = "Valor hospedagem";
            // 
            // txbValorHospedagem
            // 
            this.txbValorHospedagem.Enabled = false;
            this.txbValorHospedagem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbValorHospedagem.Location = new System.Drawing.Point(332, 166);
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
            // lblDescProduto
            // 
            this.lblDescProduto.AutoSize = true;
            this.lblDescProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescProduto.Location = new System.Drawing.Point(335, 87);
            this.lblDescProduto.Name = "lblDescProduto";
            this.lblDescProduto.Size = new System.Drawing.Size(125, 15);
            this.lblDescProduto.TabIndex = 48;
            this.lblDescProduto.Text = "Descrição do produto";
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Enabled = false;
            this.txbCodProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCodProduto.Location = new System.Drawing.Point(195, 105);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(103, 21);
            this.txbCodProduto.TabIndex = 1;
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
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodProduto.Location = new System.Drawing.Point(195, 87);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(109, 15);
            this.lblCodProduto.TabIndex = 1;
            this.lblCodProduto.Text = "Código do produto";
            // 
            // dgvConsumo
            // 
            this.dgvConsumo.AllowUserToAddRows = false;
            this.dgvConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumo.Location = new System.Drawing.Point(30, 287);
            this.dgvConsumo.Name = "dgvConsumo";
            this.dgvConsumo.ReadOnly = true;
            this.dgvConsumo.RowTemplate.Height = 25;
            this.dgvConsumo.Size = new System.Drawing.Size(622, 198);
            this.dgvConsumo.TabIndex = 5;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.Enabled = false;
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncluir.Location = new System.Drawing.Point(558, 502);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(94, 28);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // eprSemPreenchimento
            // 
            this.eprSemPreenchimento.ContainerControl = this;
            // 
            // eprDadoInvalido
            // 
            this.eprDadoInvalido.ContainerControl = this;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(443, 502);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 28);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmIncluirConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 551);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvConsumo);
            this.Controls.Add(this.pnlDadosConsumo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIncluirConsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIncluirConsumo_FormClosing);
            this.pnlDadosConsumo.ResumeLayout(false);
            this.pnlDadosConsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDadosConsumo;
        private System.Windows.Forms.Label lblPrecoHospedagem;
        private System.Windows.Forms.TextBox txbValorHospedagem;
        private System.Windows.Forms.PictureBox imgLocalizar;
        private System.Windows.Forms.Label lblDescProduto;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Label lblNumReserva;
        private System.Windows.Forms.TextBox txbNumReserva;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txbPrecoTotal;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.DataGridView dgvConsumo;
        private System.Windows.Forms.ComboBox cbxDescProduto;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ErrorProvider eprSemPreenchimento;
        private System.Windows.Forms.ErrorProvider eprDadoInvalido;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbPrecoUnitario;
        private System.Windows.Forms.Label lblPreco;
    }
}