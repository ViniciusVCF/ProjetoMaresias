
namespace ProjetoMaresias.Forms.Forms_Produto
{
    partial class FrmAlterarDadosProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarDadosProduto));
            this.eprSemPreenchimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlDadosQuarto = new System.Windows.Forms.Panel();
            this.imgLocalizar = new System.Windows.Forms.PictureBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescricaoQuarto = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).BeginInit();
            this.pnlDadosQuarto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).BeginInit();
            this.SuspendLayout();
            // 
            // eprSemPreenchimento
            // 
            this.eprSemPreenchimento.ContainerControl = this;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(441, 375);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 28);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlDadosQuarto
            // 
            this.pnlDadosQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDadosQuarto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDadosQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosQuarto.Controls.Add(this.imgLocalizar);
            this.pnlDadosQuarto.Controls.Add(this.cbxCategoria);
            this.pnlDadosQuarto.Controls.Add(this.cbxStatus);
            this.pnlDadosQuarto.Controls.Add(this.lblStatus);
            this.pnlDadosQuarto.Controls.Add(this.lblCategoria);
            this.pnlDadosQuarto.Controls.Add(this.txbQuantidade);
            this.pnlDadosQuarto.Controls.Add(this.lblPreco);
            this.pnlDadosQuarto.Controls.Add(this.txbPreco);
            this.pnlDadosQuarto.Controls.Add(this.lblCodProduto);
            this.pnlDadosQuarto.Controls.Add(this.txbCodigo);
            this.pnlDadosQuarto.Controls.Add(this.lblQuantidade);
            this.pnlDadosQuarto.Controls.Add(this.lblDescricaoQuarto);
            this.pnlDadosQuarto.Controls.Add(this.txbDescricao);
            this.pnlDadosQuarto.ForeColor = System.Drawing.Color.Peru;
            this.pnlDadosQuarto.Location = new System.Drawing.Point(29, 20);
            this.pnlDadosQuarto.Name = "pnlDadosQuarto";
            this.pnlDadosQuarto.Size = new System.Drawing.Size(506, 339);
            this.pnlDadosQuarto.TabIndex = 9;
            // 
            // imgLocalizar
            // 
            this.imgLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLocalizar.Image = ((System.Drawing.Image)(resources.GetObject("imgLocalizar.Image")));
            this.imgLocalizar.Location = new System.Drawing.Point(136, 32);
            this.imgLocalizar.Name = "imgLocalizar";
            this.imgLocalizar.Size = new System.Drawing.Size(23, 21);
            this.imgLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLocalizar.TabIndex = 71;
            this.imgLocalizar.TabStop = false;
            this.imgLocalizar.Click += new System.EventHandler(this.imgLocalizar_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(23, 137);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoria.TabIndex = 47;
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Enabled = false;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cbxStatus.Location = new System.Drawing.Point(23, 298);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(42, 23);
            this.cbxStatus.TabIndex = 46;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(23, 279);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 45;
            this.lblStatus.Text = "Status";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoria.Location = new System.Drawing.Point(23, 119);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 15);
            this.lblCategoria.TabIndex = 43;
            this.lblCategoria.Text = "Categoria";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Enabled = false;
            this.txbQuantidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbQuantidade.Location = new System.Drawing.Point(23, 192);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(107, 21);
            this.txbQuantidade.TabIndex = 2;
            this.txbQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.Location = new System.Drawing.Point(23, 226);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(78, 15);
            this.lblPreco.TabIndex = 41;
            this.lblPreco.Text = "Valor unitário";
            // 
            // txbPreco
            // 
            this.txbPreco.Enabled = false;
            this.txbPreco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPreco.Location = new System.Drawing.Point(23, 244);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(107, 21);
            this.txbPreco.TabIndex = 3;
            this.txbPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroDecimal);
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
            this.txbCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCodigo.Location = new System.Drawing.Point(23, 32);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(107, 21);
            this.txbCodigo.TabIndex = 0;
            this.txbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(23, 174);
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
            // txbDescricao
            // 
            this.txbDescricao.Enabled = false;
            this.txbDescricao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDescricao.Location = new System.Drawing.Point(23, 83);
            this.txbDescricao.MaxLength = 150;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(250, 21);
            this.txbDescricao.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.Location = new System.Drawing.Point(332, 375);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(94, 28);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // FrmAlterarDadosProduto
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 423);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnlDadosQuarto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAlterarDadosProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar dados do produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlterarDadosProduto_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlterarDadosProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).EndInit();
            this.pnlDadosQuarto.ResumeLayout(false);
            this.pnlDadosQuarto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocalizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider eprSemPreenchimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel pnlDadosQuarto;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescricaoQuarto;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.PictureBox imgLocalizar;
    }
}