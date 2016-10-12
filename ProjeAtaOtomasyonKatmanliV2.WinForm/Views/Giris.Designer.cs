namespace ProjeAtaOtomasyonKatmanliV2.DataAccess
{
    partial class Giris
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
            this.lblSoyAdi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSoyAdi
            // 
            this.lblSoyAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoyAdi.AutoSize = true;
            this.lblSoyAdi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSoyAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyAdi.Location = new System.Drawing.Point(11, 93);
            this.lblSoyAdi.Name = "lblSoyAdi";
            this.lblSoyAdi.Size = new System.Drawing.Size(57, 16);
            this.lblSoyAdi.TabIndex = 48;
            this.lblSoyAdi.Text = "Soyadı";
            this.lblSoyAdi.Visible = false;
            // 
            // lblAdi
            // 
            this.lblAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdi.AutoSize = true;
            this.lblAdi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(20, 52);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(31, 16);
            this.lblAdi.TabIndex = 47;
            this.lblAdi.Text = "Adı";
            this.lblAdi.Visible = false;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoyadi.Location = new System.Drawing.Point(100, 86);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(191, 20);
            this.txtSoyadi.TabIndex = 39;
            this.txtSoyadi.Visible = false;
            this.txtSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlp_KeyPress);
            // 
            // txtAdi
            // 
            this.txtAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdi.Location = new System.Drawing.Point(100, 49);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(191, 20);
            this.txtAdi.TabIndex = 38;
            this.txtAdi.Visible = false;
            this.txtAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlp_KeyPress);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYeniKayit.Location = new System.Drawing.Point(100, 268);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(95, 20);
            this.btnYeniKayit.TabIndex = 44;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(14, 171);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(40, 16);
            this.lblSifre.TabIndex = 45;
            this.lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSifre.Location = new System.Drawing.Point(100, 168);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(191, 20);
            this.txtSifre.TabIndex = 42;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(168, 15);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(40, 16);
            this.lblBaslik.TabIndex = 43;
            this.lblBaslik.Text = "Giriş";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(100, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 41;
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGiris.Location = new System.Drawing.Point(196, 268);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(95, 20);
            this.btnGiris.TabIndex = 46;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblTel
            // 
            this.lblTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(14, 209);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 16);
            this.lblTel.TabIndex = 50;
            this.lblTel.Text = "Telefon";
            this.lblTel.Visible = false;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTel.Location = new System.Drawing.Point(100, 206);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 20);
            this.txtTel.TabIndex = 49;
            this.txtTel.Visible = false;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjeAtaOtomasyonKatmanliV2.WinForm.Properties.Resources.Giris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 302);
            this.Controls.Add(this.lblSoyAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTel);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoyAdi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
    }
}