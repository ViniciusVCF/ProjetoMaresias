
namespace ProjetoMaresias.Forms.Forms_Quarto
{
    partial class FrmCadastrarQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarQuarto));
            this.pnlDadosQuarto = new System.Windows.Forms.Panel();
            this.txbAndar = new System.Windows.Forms.TextBox();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.txbDiaria = new System.Windows.Forms.TextBox();
            this.lblNumQuarto = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblAndar = new System.Windows.Forms.Label();
            this.lblDescricaoQuarto = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.eprSemPreenchimento = new System.Windows.Forms.ErrorProvider(this.components);
            this.eprDadoInvalido = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlDadosQuarto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDadosQuarto
            // 
            this.pnlDadosQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDadosQuarto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDadosQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosQuarto.Controls.Add(this.txbAndar);
            this.pnlDadosQuarto.Controls.Add(this.lblDiaria);
            this.pnlDadosQuarto.Controls.Add(this.txbDiaria);
            this.pnlDadosQuarto.Controls.Add(this.lblNumQuarto);
            this.pnlDadosQuarto.Controls.Add(this.txbNumero);
            this.pnlDadosQuarto.Controls.Add(this.lblAndar);
            this.pnlDadosQuarto.Controls.Add(this.lblDescricaoQuarto);
            this.pnlDadosQuarto.Controls.Add(this.txbDescricao);
            this.pnlDadosQuarto.ForeColor = System.Drawing.Color.Peru;
            this.pnlDadosQuarto.Location = new System.Drawing.Point(29, 28);
            this.pnlDadosQuarto.Name = "pnlDadosQuarto";
            this.pnlDadosQuarto.Size = new System.Drawing.Size(506, 235);
            this.pnlDadosQuarto.TabIndex = 2;
            this.pnlDadosQuarto.Validated += new System.EventHandler(this.pnlDadosQuarto_Validated);
            // 
            // txbAndar
            // 
            this.txbAndar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbAndar.Location = new System.Drawing.Point(23, 135);
            this.txbAndar.MaxLength = 2;
            this.txbAndar.Name = "txbAndar";
            this.txbAndar.Size = new System.Drawing.Size(107, 21);
            this.txbAndar.TabIndex = 3;
            this.txbAndar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbAndar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            // 
            // lblDiaria
            // 
            this.lblDiaria.AutoSize = true;
            this.lblDiaria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiaria.Location = new System.Drawing.Point(23, 169);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(85, 15);
            this.lblDiaria.TabIndex = 41;
            this.lblDiaria.Text = "Valor da diária";
            // 
            // txbDiaria
            // 
            this.txbDiaria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDiaria.Location = new System.Drawing.Point(23, 187);
            this.txbDiaria.Name = "txbDiaria";
            this.txbDiaria.Size = new System.Drawing.Size(107, 21);
            this.txbDiaria.TabIndex = 4;
            this.txbDiaria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroDecimal);
            // 
            // lblNumQuarto
            // 
            this.lblNumQuarto.AutoSize = true;
            this.lblNumQuarto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumQuarto.Location = new System.Drawing.Point(23, 14);
            this.lblNumQuarto.Name = "lblNumQuarto";
            this.lblNumQuarto.Size = new System.Drawing.Size(52, 15);
            this.lblNumQuarto.TabIndex = 12;
            this.lblNumQuarto.Text = "Número";
            // 
            // txbNumero
            // 
            this.txbNumero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumero.Location = new System.Drawing.Point(23, 32);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(107, 21);
            this.txbNumero.TabIndex = 0;
            this.txbNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_KeyDown);
            this.txbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            // 
            // lblAndar
            // 
            this.lblAndar.AutoSize = true;
            this.lblAndar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAndar.Location = new System.Drawing.Point(23, 117);
            this.lblAndar.Name = "lblAndar";
            this.lblAndar.Size = new System.Drawing.Size(39, 15);
            this.lblAndar.TabIndex = 9;
            this.lblAndar.Text = "Andar";
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
            this.txbDescricao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDescricao.Location = new System.Drawing.Point(23, 83);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(250, 21);
            this.txbDescricao.TabIndex = 1;
            // 
            // eprSemPreenchimento
            // 
            this.eprSemPreenchimento.ContainerControl = this;
            // 
            // eprDadoInvalido
            // 
            this.eprDadoInvalido.ContainerControl = this;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(441, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 28);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadastrarQuarto
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 344);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pnlDadosQuarto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar quarto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastrarQuarto_FormClosing);
            this.pnlDadosQuarto.ResumeLayout(false);
            this.pnlDadosQuarto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprSemPreenchimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprDadoInvalido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDadosQuarto;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.TextBox txbDiaria;
        private System.Windows.Forms.Label lblNumQuarto;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblAndar;
        private System.Windows.Forms.Label lblDescricaoQuarto;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.ErrorProvider eprSemPreenchimento;
        private System.Windows.Forms.ErrorProvider eprDadoInvalido;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbAndar;
    }
}