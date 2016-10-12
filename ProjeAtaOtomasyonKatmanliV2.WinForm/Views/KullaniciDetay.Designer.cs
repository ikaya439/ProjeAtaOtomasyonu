namespace ProjeAtaOtomasyonKatmanliV2.WinForm.Views
{
    partial class KullaniciDetay
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
            this.versiyonGrid = new System.Windows.Forms.DataGridView();
            this.ProjeGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPgProjeler = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgOzBilgi = new System.Windows.Forms.TabPage();
            this.pcrBxKullanici = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.versiyonGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjeGrid)).BeginInit();
            this.tbPgProjeler.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPgOzBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBxKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // versiyonGrid
            // 
            this.versiyonGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versiyonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versiyonGrid.Location = new System.Drawing.Point(6, 267);
            this.versiyonGrid.MultiSelect = false;
            this.versiyonGrid.Name = "versiyonGrid";
            this.versiyonGrid.ReadOnly = true;
            this.versiyonGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.versiyonGrid.Size = new System.Drawing.Size(896, 190);
            this.versiyonGrid.TabIndex = 6;
            this.versiyonGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.versiyonGrid_CellContentClick);
            // 
            // ProjeGrid
            // 
            this.ProjeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjeGrid.Location = new System.Drawing.Point(6, 31);
            this.ProjeGrid.MultiSelect = false;
            this.ProjeGrid.Name = "ProjeGrid";
            this.ProjeGrid.ReadOnly = true;
            this.ProjeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjeGrid.Size = new System.Drawing.Size(896, 190);
            this.ProjeGrid.TabIndex = 4;
            this.ProjeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjeGrid_CellContentClick);
            this.ProjeGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProjeGrid_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(386, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(383, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(386, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "İsim";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(494, 65);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 18);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(397, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Versiyonlar";
            // 
            // tbPgProjeler
            // 
            this.tbPgProjeler.Controls.Add(this.label4);
            this.tbPgProjeler.Controls.Add(this.versiyonGrid);
            this.tbPgProjeler.Controls.Add(this.label3);
            this.tbPgProjeler.Controls.Add(this.ProjeGrid);
            this.tbPgProjeler.Location = new System.Drawing.Point(4, 22);
            this.tbPgProjeler.Margin = new System.Windows.Forms.Padding(0);
            this.tbPgProjeler.Name = "tbPgProjeler";
            this.tbPgProjeler.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgProjeler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPgProjeler.Size = new System.Drawing.Size(908, 463);
            this.tbPgProjeler.TabIndex = 1;
            this.tbPgProjeler.Text = "Projeler";
            this.tbPgProjeler.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(416, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Projeler";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEMail.Location = new System.Drawing.Point(491, 101);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(50, 18);
            this.lblEMail.TabIndex = 5;
            this.lblEMail.Text = "E-mail";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.Location = new System.Drawing.Point(494, 30);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(35, 18);
            this.lblIsim.TabIndex = 2;
            this.lblIsim.Text = "İsim";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbPgOzBilgi);
            this.tabControl1.Controls.Add(this.tbPgProjeler);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 489);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPgOzBilgi
            // 
            this.tbPgOzBilgi.Controls.Add(this.label5);
            this.tbPgOzBilgi.Controls.Add(this.label6);
            this.tbPgOzBilgi.Controls.Add(this.label7);
            this.tbPgOzBilgi.Controls.Add(this.lblTel);
            this.tbPgOzBilgi.Controls.Add(this.lblEMail);
            this.tbPgOzBilgi.Controls.Add(this.lblIsim);
            this.tbPgOzBilgi.Controls.Add(this.pcrBxKullanici);
            this.tbPgOzBilgi.Location = new System.Drawing.Point(4, 22);
            this.tbPgOzBilgi.Name = "tbPgOzBilgi";
            this.tbPgOzBilgi.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgOzBilgi.Size = new System.Drawing.Size(908, 463);
            this.tbPgOzBilgi.TabIndex = 0;
            this.tbPgOzBilgi.Text = "Kişilik Bilgileri";
            this.tbPgOzBilgi.UseVisualStyleBackColor = true;
            // 
            // pcrBxKullanici
            // 
            this.pcrBxKullanici.Location = new System.Drawing.Point(6, 16);
            this.pcrBxKullanici.Name = "pcrBxKullanici";
            this.pcrBxKullanici.Size = new System.Drawing.Size(129, 140);
            this.pcrBxKullanici.TabIndex = 1;
            this.pcrBxKullanici.TabStop = false;
            // 
            // KullaniciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "KullaniciDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciDetay";
            this.Load += new System.EventHandler(this.KullaniciDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.versiyonGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjeGrid)).EndInit();
            this.tbPgProjeler.ResumeLayout(false);
            this.tbPgProjeler.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbPgOzBilgi.ResumeLayout(false);
            this.tbPgOzBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrBxKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView versiyonGrid;
        private System.Windows.Forms.DataGridView ProjeGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tbPgProjeler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.PictureBox pcrBxKullanici;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgOzBilgi;
    }
}