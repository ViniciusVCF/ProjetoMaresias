
namespace ProjetoMaresias.Forms
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.imgRH = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgRecepcao = new System.Windows.Forms.PictureBox();
            this.imgFinanceiro = new System.Windows.Forms.PictureBox();
            this.imgQuartos = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblRH = new System.Windows.Forms.Label();
            this.lblFinanceiro = new System.Windows.Forms.Label();
            this.lblQuartos = new System.Windows.Forms.Label();
            this.lblRecepcao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecepcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuartos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgRH
            // 
            this.imgRH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgRH.Image = ((System.Drawing.Image)(resources.GetObject("imgRH.Image")));
            this.imgRH.Location = new System.Drawing.Point(503, 20);
            this.imgRH.Name = "imgRH";
            this.imgRH.Size = new System.Drawing.Size(81, 59);
            this.imgRH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRH.TabIndex = 0;
            this.imgRH.TabStop = false;
            this.imgRH.Click += new System.EventHandler(this.imgRH_Click);
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.White;
            this.imgUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(12, 12);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(38, 30);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 7;
            this.imgUser.TabStop = false;
            this.imgUser.Click += new System.EventHandler(this.imgUser_Click);
            // 
            // imgRecepcao
            // 
            this.imgRecepcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgRecepcao.Image = ((System.Drawing.Image)(resources.GetObject("imgRecepcao.Image")));
            this.imgRecepcao.Location = new System.Drawing.Point(47, 20);
            this.imgRecepcao.Name = "imgRecepcao";
            this.imgRecepcao.Size = new System.Drawing.Size(81, 59);
            this.imgRecepcao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRecepcao.TabIndex = 1;
            this.imgRecepcao.TabStop = false;
            this.imgRecepcao.Click += new System.EventHandler(this.imgRecepcao_Click);
            // 
            // imgFinanceiro
            // 
            this.imgFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("imgFinanceiro.Image")));
            this.imgFinanceiro.Location = new System.Drawing.Point(354, 20);
            this.imgFinanceiro.Name = "imgFinanceiro";
            this.imgFinanceiro.Size = new System.Drawing.Size(81, 59);
            this.imgFinanceiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFinanceiro.TabIndex = 2;
            this.imgFinanceiro.TabStop = false;
            this.imgFinanceiro.Click += new System.EventHandler(this.imgFinanceiro_Click);
            // 
            // imgQuartos
            // 
            this.imgQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgQuartos.Image = ((System.Drawing.Image)(resources.GetObject("imgQuartos.Image")));
            this.imgQuartos.Location = new System.Drawing.Point(203, 20);
            this.imgQuartos.Name = "imgQuartos";
            this.imgQuartos.Size = new System.Drawing.Size(81, 59);
            this.imgQuartos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgQuartos.TabIndex = 3;
            this.imgQuartos.TabStop = false;
            this.imgQuartos.Click += new System.EventHandler(this.imgQuartos_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(314, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(199, 159);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 4;
            this.imgLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblRH);
            this.pnlMenu.Controls.Add(this.lblFinanceiro);
            this.pnlMenu.Controls.Add(this.lblQuartos);
            this.pnlMenu.Controls.Add(this.lblRecepcao);
            this.pnlMenu.Controls.Add(this.imgRecepcao);
            this.pnlMenu.Controls.Add(this.imgRH);
            this.pnlMenu.Controls.Add(this.imgFinanceiro);
            this.pnlMenu.Controls.Add(this.imgQuartos);
            this.pnlMenu.Location = new System.Drawing.Point(93, 191);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(639, 110);
            this.pnlMenu.TabIndex = 6;
            // 
            // lblRH
            // 
            this.lblRH.AutoSize = true;
            this.lblRH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRH.ForeColor = System.Drawing.Color.Peru;
            this.lblRH.Location = new System.Drawing.Point(530, 82);
            this.lblRH.Name = "lblRH";
            this.lblRH.Size = new System.Drawing.Size(26, 15);
            this.lblRH.TabIndex = 10;
            this.lblRH.Text = "R.H";
            // 
            // lblFinanceiro
            // 
            this.lblFinanceiro.AutoSize = true;
            this.lblFinanceiro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinanceiro.ForeColor = System.Drawing.Color.Peru;
            this.lblFinanceiro.Location = new System.Drawing.Point(361, 82);
            this.lblFinanceiro.Name = "lblFinanceiro";
            this.lblFinanceiro.Size = new System.Drawing.Size(66, 15);
            this.lblFinanceiro.TabIndex = 9;
            this.lblFinanceiro.Text = "Financeiro";
            // 
            // lblQuartos
            // 
            this.lblQuartos.AutoSize = true;
            this.lblQuartos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuartos.ForeColor = System.Drawing.Color.Peru;
            this.lblQuartos.Location = new System.Drawing.Point(218, 82);
            this.lblQuartos.Name = "lblQuartos";
            this.lblQuartos.Size = new System.Drawing.Size(53, 15);
            this.lblQuartos.TabIndex = 8;
            this.lblQuartos.Text = "Quartos";
            // 
            // lblRecepcao
            // 
            this.lblRecepcao.AutoSize = true;
            this.lblRecepcao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecepcao.ForeColor = System.Drawing.Color.Peru;
            this.lblRecepcao.Location = new System.Drawing.Point(56, 82);
            this.lblRecepcao.Name = "lblRecepcao";
            this.lblRecepcao.Size = new System.Drawing.Size(64, 15);
            this.lblRecepcao.TabIndex = 6;
            this.lblRecepcao.Text = "Recepção";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 409);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenuPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecepcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuartos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgRH;
        private System.Windows.Forms.PictureBox imgRecepcao;
        private System.Windows.Forms.PictureBox imgFinanceiro;
        private System.Windows.Forms.PictureBox imgQuartos;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblRH;
        private System.Windows.Forms.Label lblFinanceiro;
        private System.Windows.Forms.Label lblQuartos;
        private System.Windows.Forms.Label lblRecepcao;
        private System.Windows.Forms.PictureBox imgUser;
    }
}