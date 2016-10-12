namespace ProjeAtaOtomasyonKatmanliV2.WinForm.Views
{
    partial class Projeler
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTanitim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblArama = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnYeniProje = new System.Windows.Forms.Button();
            this.projeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.projeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Tanıtım";
            // 
            // txtTanitim
            // 
            this.txtTanitim.Location = new System.Drawing.Point(300, 73);
            this.txtTanitim.Name = "txtTanitim";
            this.txtTanitim.Size = new System.Drawing.Size(136, 20);
            this.txtTanitim.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Konu";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(158, 74);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(136, 20);
            this.txtKonu.TabIndex = 91;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(442, 71);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 90;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lblArama
            // 
            this.lblArama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.Location = new System.Drawing.Point(409, 11);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(65, 24);
            this.lblArama.TabIndex = 89;
            this.lblArama.Text = "Arama";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(13, 46);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(22, 13);
            this.lblAdi.TabIndex = 88;
            this.lblAdi.Text = "Adı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(16, 73);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(136, 20);
            this.txtAdi.TabIndex = 87;
            // 
            // btnYeniProje
            // 
            this.btnYeniProje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeniProje.AutoSize = true;
            this.btnYeniProje.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYeniProje.Location = new System.Drawing.Point(873, 63);
            this.btnYeniProje.Name = "btnYeniProje";
            this.btnYeniProje.Size = new System.Drawing.Size(65, 23);
            this.btnYeniProje.TabIndex = 86;
            this.btnYeniProje.Text = "Yeni Proje";
            this.btnYeniProje.UseVisualStyleBackColor = true;
            this.btnYeniProje.Click += new System.EventHandler(this.btnYeniProje_Click);
            // 
            // projeGrid
            // 
            this.projeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projeGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.projeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projeGrid.Location = new System.Drawing.Point(16, 123);
            this.projeGrid.MultiSelect = false;
            this.projeGrid.Name = "projeGrid";
            this.projeGrid.ReadOnly = true;
            this.projeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projeGrid.Size = new System.Drawing.Size(922, 241);
            this.projeGrid.TabIndex = 85;
            this.projeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projeGrid_CellContentClick);
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTanitim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnYeniProje);
            this.Controls.Add(this.projeGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projeler";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.Projeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTanitim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnYeniProje;
        private System.Windows.Forms.DataGridView projeGrid;
    }
}