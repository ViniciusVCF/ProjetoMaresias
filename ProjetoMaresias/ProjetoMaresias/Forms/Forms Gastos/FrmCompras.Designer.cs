
namespace ProjetoMaresias.Forms.Forms_Gastos
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            this.pnlDadosCompras = new System.Windows.Forms.Panel();
            this.cbxDescProduto = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescricaoQuarto = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.eprSemPreenchimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.eprDadoInvalido = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDadosCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDadosCompras
            // 
            this.pnlDadosCompras.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDadosCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDadosCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosCompras.Controls.Add(this.cbxDescProduto);
            this.pnlDadosCompras.Controls.Add(this.dtpData);
            this.pnlDadosCompras.Controls.Add(this.lblData);
            this.pnlDadosCompras.Controls.Add(this.lblValorTotal);
            this.pnlDadosCompras.Controls.Add(this.txbValorTotal);
            this.pnlDadosCompras.Controls.Add(this.txbQuantidade);
            this.pnlDadosCompras.Controls.Add(this.lblPreco);
            this.pnlDadosCompras.Controls.Add(this.txbPreco);
            this.pnlDadosCompras.Controls.Add(this.lblCodProduto);
            this.pnlDadosCompras.Controls.Add(this.txbCodigo);
            this.pnlDadosCompras.Controls.Add(this.lblQuantidade);
            this.pnlDadosCompras.Controls.Add(this.lblDescricaoQuarto);
            this.pnlDadosCompras.ForeColor = System.Drawing.Color.Peru;
            this.pnlDadosCompras.Location = new System.Drawing.Point(29, 28);
            this.pnlDadosCompras.Name = "pnlDadosCompras";
            this.pnlDadosCompras.Size = new System.Drawing.Size(506, 339);
            this.pnlDadosCompras.TabIndex = 8;
            this.pnlDadosCompras.Validated += new System.EventHandler(this.pnlDadosCompras_Validated);
            // 
            // cbxDescProduto
            // 
            this.cbxDescProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDescProduto.FormattingEnabled = true;
            this.cbxDescProduto.Location = new System.Drawing.Point(23, 83);
            this.cbxDescProduto.Name = "cbxDescProduto";
            this.cbxDescProduto.Size = new System.Drawing.Size(157, 23);
            this.cbxDescProduto.TabIndex = 1;
            this.cbxDescProduto.TextChanged += new System.EventHandler(this.cbxDescProduto_TextChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(23, 295);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 23);
            this.dtpData.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(23, 277);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(116, 15);
            this.lblData.TabIndex = 45;
            this.lblData.Text = "Data do pagamento";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.Location = new System.Drawing.Point(23, 225);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(60, 15);
            this.lblValorTotal.TabIndex = 43;
            this.lblValorTotal.Text = "Valor total";
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Enabled = false;
            this.txbValorTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbValorTotal.Location = new System.Drawing.Point(23, 243);
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.Size = new System.Drawing.Size(107, 21);
            this.txbValorTotal.TabIndex = 4;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbQuantidade.Location = new System.Drawing.Point(23, 138);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(107, 21);
            this.txbQuantidade.TabIndex = 2;
            this.txbQuantidade.Text = "1";
            this.txbQuantidade.TextChanged += new System.EventHandler(this.txbQuantidade_TextChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.Location = new System.Drawing.Point(23, 172);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(78, 15);
            this.lblPreco.TabIndex = 41;
            this.lblPreco.Text = "Valor unitário";
            // 
            // txbPreco
            // 
            this.txbPreco.Enabled = false;
            this.txbPreco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPreco.Location = new System.Drawing.Point(23, 190);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(107, 21);
            this.txbPreco.TabIndex = 3;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodProduto.Location = new System.Drawing.Point(23, 14);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(47, 15);
            this.lblCodProduto.TabIndex = 12;
            this.lblCodProduto.Text = "Código";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCodigo.Location = new System.Drawing.Point(23, 32);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(107, 21);
            this.txbCodigo.TabIndex = 0;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(23, 120);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(71, 15);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDescricaoQuarto
            // 
            this.lblDescricaoQuarto.AutoSize = true;
            this.lblDescricaoQuarto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricaoQuarto.Location = new System.Drawing.Point(23, 65);
            this.lblDescricaoQuarto.Name = "lblDescricaoQuarto";
            this.lblDescricaoQuarto.Size = new System.Drawing.Size(63, 15);
            this.lblDescricaoQuarto.TabIndex = 1;
            this.lblDescricaoQuarto.Text = "Descrição";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(441, 383);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 28);
            this.btnSalvar.TabIndex = 6;
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
            // FrmCompras
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 423);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnlDadosCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompras_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.pnlDadosCompras.ResumeLayout(false);
            this.pnlDadosCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDadosCompras;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescricaoQuarto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.ComboBox cbxDescProduto;
        private System.Windows.Forms.ErrorProvider eprSemPreenchimento;
        private System.Windows.Forms.ErrorProvider eprDadoInvalido;
    }
}