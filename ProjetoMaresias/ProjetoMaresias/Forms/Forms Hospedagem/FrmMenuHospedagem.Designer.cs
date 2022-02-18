
namespace ProjetoMaresias.Forms.Forms_Hospedagem
{
    partial class FrmMenuHospedagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuHospedagem));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.lblIncluirConsumo = new System.Windows.Forms.Label();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.imgCheckin = new System.Windows.Forms.PictureBox();
            this.imgConsumo = new System.Windows.Forms.PictureBox();
            this.imgCheckout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(314, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(199, 159);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 11;
            this.imgLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblCheckin);
            this.pnlMenu.Controls.Add(this.lblIncluirConsumo);
            this.pnlMenu.Controls.Add(this.lblCheckout);
            this.pnlMenu.Controls.Add(this.imgCheckin);
            this.pnlMenu.Controls.Add(this.imgConsumo);
            this.pnlMenu.Controls.Add(this.imgCheckout);
            this.pnlMenu.Location = new System.Drawing.Point(93, 191);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(639, 110);
            this.pnlMenu.TabIndex = 15;
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckin.ForeColor = System.Drawing.Color.Peru;
            this.lblCheckin.Location = new System.Drawing.Point(477, 78);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(57, 15);
            this.lblCheckin.TabIndex = 10;
            this.lblCheckin.Text = "Check-in";
            // 
            // lblIncluirConsumo
            // 
            this.lblIncluirConsumo.AutoSize = true;
            this.lblIncluirConsumo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncluirConsumo.ForeColor = System.Drawing.Color.Peru;
            this.lblIncluirConsumo.Location = new System.Drawing.Point(284, 78);
            this.lblIncluirConsumo.Name = "lblIncluirConsumo";
            this.lblIncluirConsumo.Size = new System.Drawing.Size(61, 15);
            this.lblIncluirConsumo.TabIndex = 9;
            this.lblIncluirConsumo.Text = "Consumo";
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCheckout.ForeColor = System.Drawing.Color.Peru;
            this.lblCheckout.Location = new System.Drawing.Point(78, 78);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(65, 15);
            this.lblCheckout.TabIndex = 8;
            this.lblCheckout.Text = "Check-out";
            // 
            // imgCheckin
            // 
            this.imgCheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCheckin.Image = ((System.Drawing.Image)(resources.GetObject("imgCheckin.Image")));
            this.imgCheckin.Location = new System.Drawing.Point(471, 16);
            this.imgCheckin.Name = "imgCheckin";
            this.imgCheckin.Size = new System.Drawing.Size(81, 59);
            this.imgCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCheckin.TabIndex = 0;
            this.imgCheckin.TabStop = false;
            this.imgCheckin.Click += new System.EventHandler(this.imgCheckin_Click);
            // 
            // imgConsumo
            // 
            this.imgConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgConsumo.Image = ((System.Drawing.Image)(resources.GetObject("imgConsumo.Image")));
            this.imgConsumo.Location = new System.Drawing.Point(275, 16);
            this.imgConsumo.Name = "imgConsumo";
            this.imgConsumo.Size = new System.Drawing.Size(81, 59);
            this.imgConsumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConsumo.TabIndex = 2;
            this.imgConsumo.TabStop = false;
            this.imgConsumo.Click += new System.EventHandler(this.imgConsumo_Click);
            // 
            // imgCheckout
            // 
            this.imgCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgCheckout.Image = ((System.Drawing.Image)(resources.GetObject("imgCheckout.Image")));
            this.imgCheckout.Location = new System.Drawing.Point(76, 16);
            this.imgCheckout.Name = "imgCheckout";
            this.imgCheckout.Size = new System.Drawing.Size(81, 59);
            this.imgCheckout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCheckout.TabIndex = 3;
            this.imgCheckout.TabStop = false;
            this.imgCheckout.Click += new System.EventHandler(this.imgCheckout_Click);
            // 
            // FrmMenuHospedagem
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
            this.Name = "FrmMenuHospedagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu hospedagem";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCheckout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Label lblIncluirConsumo;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.PictureBox imgCheckin;
        private System.Windows.Forms.PictureBox imgConsumo;
        private System.Windows.Forms.PictureBox imgCheckout;
    }
}