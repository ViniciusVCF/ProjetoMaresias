
namespace ProjetoMaresias.Forms
{
    partial class FrmMenuRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuRH));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.imgCadastrar = new System.Windows.Forms.PictureBox();
            this.imgAlterar = new System.Windows.Forms.PictureBox();
            this.imgRecepcao = new System.Windows.Forms.PictureBox();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.lblLocalizar = new System.Windows.Forms.Label();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecepcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.imgCadastrar);
            this.pnlMenu.Controls.Add(this.imgAlterar);
            this.pnlMenu.Controls.Add(this.imgRecepcao);
            this.pnlMenu.Controls.Add(this.lblCadastrar);
            this.pnlMenu.Controls.Add(this.lblLocalizar);
            this.pnlMenu.Controls.Add(this.lblFuncionarios);
            this.pnlMenu.Location = new System.Drawing.Point(93, 191);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(639, 110);
            this.pnlMenu.TabIndex = 8;
            // 
            // imgCadastrar
            // 
            this.imgCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("imgCadastrar.Image")));
            this.imgCadastrar.Location = new System.Drawing.Point(460, 20);
            this.imgCadastrar.Name = "imgCadastrar";
            this.imgCadastrar.Size = new System.Drawing.Size(81, 59);
            this.imgCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCadastrar.TabIndex = 13;
            this.imgCadastrar.TabStop = false;
            this.imgCadastrar.Click += new System.EventHandler(this.imgCadastrar_Click);
            // 
            // imgAlterar
            // 
            this.imgAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAlterar.Image = ((System.Drawing.Image)(resources.GetObject("imgAlterar.Image")));
            this.imgAlterar.Location = new System.Drawing.Point(277, 20);
            this.imgAlterar.Name = "imgAlterar";
            this.imgAlterar.Size = new System.Drawing.Size(81, 59);
            this.imgAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAlterar.TabIndex = 12;
            this.imgAlterar.TabStop = false;
            this.imgAlterar.Click += new System.EventHandler(this.imgAlterar_Click);
            // 
            // imgRecepcao
            // 
            this.imgRecepcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgRecepcao.Image = ((System.Drawing.Image)(resources.GetObject("imgRecepcao.Image")));
            this.imgRecepcao.Location = new System.Drawing.Point(88, 20);
            this.imgRecepcao.Name = "imgRecepcao";
            this.imgRecepcao.Size = new System.Drawing.Size(81, 59);
            this.imgRecepcao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRecepcao.TabIndex = 11;
            this.imgRecepcao.TabStop = false;
            this.imgRecepcao.Click += new System.EventHandler(this.imgRecepcao_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCadastrar.ForeColor = System.Drawing.Color.Peru;
            this.lblCadastrar.Location = new System.Drawing.Point(434, 82);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(131, 15);
            this.lblCadastrar.TabIndex = 10;
            this.lblCadastrar.Text = "Cadastrar funcionário";
            // 
            // lblLocalizar
            // 
            this.lblLocalizar.AutoSize = true;
            this.lblLocalizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLocalizar.ForeColor = System.Drawing.Color.Peru;
            this.lblLocalizar.Location = new System.Drawing.Point(242, 82);
            this.lblLocalizar.Name = "lblLocalizar";
            this.lblLocalizar.Size = new System.Drawing.Size(151, 15);
            this.lblLocalizar.TabIndex = 9;
            this.lblLocalizar.Text = "Alterar dados funcionário";
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFuncionarios.ForeColor = System.Drawing.Color.Peru;
            this.lblFuncionarios.Location = new System.Drawing.Point(88, 82);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(80, 15);
            this.lblFuncionarios.TabIndex = 6;
            this.lblFuncionarios.Text = "Funcionários";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(314, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(199, 159);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 7;
            this.imgLogo.TabStop = false;
            // 
            // FrmMenuRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 409);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu RH";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecepcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.Label lblLocalizar;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgRecepcao;
        private System.Windows.Forms.PictureBox imgCadastrar;
        private System.Windows.Forms.PictureBox imgAlterar;
    }
}