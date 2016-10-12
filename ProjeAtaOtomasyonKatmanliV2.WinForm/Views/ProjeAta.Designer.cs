namespace ProjeAtaOtomasyonKatmanliV2.WinForm.Views
{
    partial class ProjeAta
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
            this.btnAra = new System.Windows.Forms.Button();
            this.lblSoyAdi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stajyerGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stajyerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAra.Location = new System.Drawing.Point(641, 66);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 92;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblSoyAdi
            // 
            this.lblSoyAdi.AutoSize = true;
            this.lblSoyAdi.Location = new System.Drawing.Point(226, 42);
            this.lblSoyAdi.Name = "lblSoyAdi";
            this.lblSoyAdi.Size = new System.Drawing.Size(39, 13);
            this.lblSoyAdi.TabIndex = 91;
            this.lblSoyAdi.Text = "Soyadı";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(23, 42);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(22, 13);
            this.lblAdi.TabIndex = 90;
            this.lblAdi.Text = "Adı";
            // 
            // lblArama
            // 
            this.lblArama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.Location = new System.Drawing.Point(392, 8);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(65, 24);
            this.lblArama.TabIndex = 89;
            this.lblArama.Text = "Arama";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(168, 69);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(130, 20);
            this.txtSoyadi.TabIndex = 86;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(26, 69);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(136, 20);
            this.txtAdi.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(304, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(668, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "EndDate";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(592, 156);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 83;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(700, 322);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(92, 23);
            this.btnIptal.TabIndex = 82;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(592, 322);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(102, 23);
            this.btnSec.TabIndex = 81;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(270, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Stajyer Seç";
            // 
            // stajyerGrid
            // 
            this.stajyerGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stajyerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stajyerGrid.Location = new System.Drawing.Point(12, 156);
            this.stajyerGrid.Name = "stajyerGrid";
            this.stajyerGrid.ReadOnly = true;
            this.stajyerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stajyerGrid.Size = new System.Drawing.Size(574, 189);
            this.stajyerGrid.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Tel";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(442, 68);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 20);
            this.txtTel.TabIndex = 94;
            // 
            // ProjeAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lblSoyAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stajyerGrid);
            this.Name = "ProjeAta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjeAta";
            this.Load += new System.EventHandler(this.ProjeAta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stajyerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblSoyAdi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stajyerGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
    }
}