namespace ProjeAtaOtomasyonKatmanliV2.WinForm
{
    partial class KullaniciEkleDuzenle
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
            this.lblGiris = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnEkleDuzenle = new System.Windows.Forms.Button();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblSoyAdi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblHata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Location = new System.Drawing.Point(167, 48);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(28, 13);
            this.lblGiris.TabIndex = 75;
            this.lblGiris.Text = "Ekle";
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Location = new System.Drawing.Point(215, 271);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 74;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnEkleDuzenle
            // 
            this.btnEkleDuzenle.Location = new System.Drawing.Point(123, 271);
            this.btnEkleDuzenle.Name = "btnEkleDuzenle";
            this.btnEkleDuzenle.Size = new System.Drawing.Size(86, 23);
            this.btnEkleDuzenle.TabIndex = 73;
            this.btnEkleDuzenle.Text = "Ekle";
            this.btnEkleDuzenle.UseVisualStyleBackColor = true;
            this.btnEkleDuzenle.Click += new System.EventHandler(this.btnEkleDuzenle_Click);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 238);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(43, 13);
            this.lblTel.TabIndex = 72;
            this.lblTel.Text = "Telefon";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(98, 235);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 20);
            this.txtTel.TabIndex = 71;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // lblSoyAdi
            // 
            this.lblSoyAdi.AutoSize = true;
            this.lblSoyAdi.Location = new System.Drawing.Point(12, 122);
            this.lblSoyAdi.Name = "lblSoyAdi";
            this.lblSoyAdi.Size = new System.Drawing.Size(39, 13);
            this.lblSoyAdi.TabIndex = 70;
            this.lblSoyAdi.Text = "Soyadı";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(12, 85);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(22, 13);
            this.lblAdi.TabIndex = 69;
            this.lblAdi.Text = "Adı";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(98, 115);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(191, 20);
            this.txtSoyadi.TabIndex = 64;
            this.txtSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlp_KeyPress);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(97, 81);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAdi.Size = new System.Drawing.Size(191, 20);
            this.txtAdi.TabIndex = 63;
            this.txtAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlp_KeyPress);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(12, 200);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 68;
            this.lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(98, 197);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(191, 20);
            this.txtSifre.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 66;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(123, 19);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(86, 20);
            this.lblHata.TabIndex = 76;
            this.lblHata.Text = "labelHata";
            // 
            // KullaniciEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 315);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkleDuzenle);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblSoyAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Name = "KullaniciEkleDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciEkleDuzenle";
            this.Load += new System.EventHandler(this.KullaniciEkleDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnEkleDuzenle;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblSoyAdi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblHata;
    }
}