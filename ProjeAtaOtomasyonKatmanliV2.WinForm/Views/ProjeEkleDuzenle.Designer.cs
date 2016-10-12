namespace ProjeAtaOtomasyonKatmanliV2.WinForm.Views
{
    partial class ProjeEkleDuzenle
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
            this.btnEkleDuzenle = new System.Windows.Forms.Button();
            this.rchTxtProjeTanitim = new System.Windows.Forms.RichTextBox();
            this.rchTxtProjeKonu = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEkleDuzenle
            // 
            this.btnEkleDuzenle.Location = new System.Drawing.Point(655, 223);
            this.btnEkleDuzenle.Name = "btnEkleDuzenle";
            this.btnEkleDuzenle.Size = new System.Drawing.Size(140, 23);
            this.btnEkleDuzenle.TabIndex = 41;
            this.btnEkleDuzenle.Text = "Ekle";
            this.btnEkleDuzenle.UseVisualStyleBackColor = true;
            this.btnEkleDuzenle.Click += new System.EventHandler(this.btnEkleDuzenle_Click);
            // 
            // rchTxtProjeTanitim
            // 
            this.rchTxtProjeTanitim.Location = new System.Drawing.Point(486, 98);
            this.rchTxtProjeTanitim.Name = "rchTxtProjeTanitim";
            this.rchTxtProjeTanitim.Size = new System.Drawing.Size(309, 96);
            this.rchTxtProjeTanitim.TabIndex = 37;
            this.rchTxtProjeTanitim.Text = "";
            // 
            // rchTxtProjeKonu
            // 
            this.rchTxtProjeKonu.Location = new System.Drawing.Point(233, 99);
            this.rchTxtProjeKonu.Name = "rchTxtProjeKonu";
            this.rchTxtProjeKonu.Size = new System.Drawing.Size(247, 96);
            this.rchTxtProjeKonu.TabIndex = 36;
            this.rchTxtProjeKonu.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tanitim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Konu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Adı";
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(19, 99);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(208, 20);
            this.txtProjeAdi.TabIndex = 34;
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Location = new System.Drawing.Point(462, 29);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(55, 13);
            this.lblGiris.TabIndex = 35;
            this.lblGiris.Text = "Proje Ekle";
            // 
            // ProjeEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 275);
            this.Controls.Add(this.btnEkleDuzenle);
            this.Controls.Add(this.rchTxtProjeTanitim);
            this.Controls.Add(this.rchTxtProjeKonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjeAdi);
            this.Controls.Add(this.lblGiris);
            this.Name = "ProjeEkleDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjeEkleDuzenle";
            this.Load += new System.EventHandler(this.ProjeEkleDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkleDuzenle;
        private System.Windows.Forms.RichTextBox rchTxtProjeTanitim;
        private System.Windows.Forms.RichTextBox rchTxtProjeKonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.Label lblGiris;
    }
}