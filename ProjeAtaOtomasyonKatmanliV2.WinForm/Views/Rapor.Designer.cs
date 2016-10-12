namespace ProjeAtaOtomasyonKatmanliV2.WinForm.Views
{
    partial class Rapor
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtStjAdi = new System.Windows.Forms.TextBox();
            this.finishApproveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.beginApproveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.finishEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.beginEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.finishInsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.beginInsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrjAdi = new System.Windows.Forms.TextBox();
            this.projeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.projeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "StajyerAdı";
            // 
            // txtStjAdi
            // 
            this.txtStjAdi.Location = new System.Drawing.Point(101, 113);
            this.txtStjAdi.Name = "txtStjAdi";
            this.txtStjAdi.Size = new System.Drawing.Size(137, 20);
            this.txtStjAdi.TabIndex = 43;
            // 
            // finishApproveDatePicker
            // 
            this.finishApproveDatePicker.Checked = false;
            this.finishApproveDatePicker.Location = new System.Drawing.Point(524, 113);
            this.finishApproveDatePicker.Name = "finishApproveDatePicker";
            this.finishApproveDatePicker.ShowCheckBox = true;
            this.finishApproveDatePicker.Size = new System.Drawing.Size(170, 20);
            this.finishApproveDatePicker.TabIndex = 42;
            // 
            // beginApproveDatePicker
            // 
            this.beginApproveDatePicker.Checked = false;
            this.beginApproveDatePicker.Location = new System.Drawing.Point(348, 113);
            this.beginApproveDatePicker.Name = "beginApproveDatePicker";
            this.beginApproveDatePicker.ShowCheckBox = true;
            this.beginApproveDatePicker.Size = new System.Drawing.Size(170, 20);
            this.beginApproveDatePicker.TabIndex = 41;
            this.beginApproveDatePicker.ValueChanged += new System.EventHandler(this.beginApproveDatePicker_ValueChanged);
            // 
            // finishEndDatePicker
            // 
            this.finishEndDatePicker.Checked = false;
            this.finishEndDatePicker.Location = new System.Drawing.Point(524, 86);
            this.finishEndDatePicker.Name = "finishEndDatePicker";
            this.finishEndDatePicker.ShowCheckBox = true;
            this.finishEndDatePicker.Size = new System.Drawing.Size(170, 20);
            this.finishEndDatePicker.TabIndex = 40;
            // 
            // beginEndDatePicker
            // 
            this.beginEndDatePicker.Checked = false;
            this.beginEndDatePicker.Location = new System.Drawing.Point(348, 86);
            this.beginEndDatePicker.Name = "beginEndDatePicker";
            this.beginEndDatePicker.ShowCheckBox = true;
            this.beginEndDatePicker.Size = new System.Drawing.Size(170, 20);
            this.beginEndDatePicker.TabIndex = 39;
            this.beginEndDatePicker.ValueChanged += new System.EventHandler(this.beginEndDatePicker_ValueChanged);
            // 
            // finishInsDatePicker
            // 
            this.finishInsDatePicker.Checked = false;
            this.finishInsDatePicker.Location = new System.Drawing.Point(524, 58);
            this.finishInsDatePicker.Name = "finishInsDatePicker";
            this.finishInsDatePicker.ShowCheckBox = true;
            this.finishInsDatePicker.Size = new System.Drawing.Size(170, 20);
            this.finishInsDatePicker.TabIndex = 38;
            // 
            // beginInsDatePicker
            // 
            this.beginInsDatePicker.Checked = false;
            this.beginInsDatePicker.Location = new System.Drawing.Point(348, 58);
            this.beginInsDatePicker.Name = "beginInsDatePicker";
            this.beginInsDatePicker.ShowCheckBox = true;
            this.beginInsDatePicker.Size = new System.Drawing.Size(170, 20);
            this.beginInsDatePicker.TabIndex = 37;
            this.beginInsDatePicker.ValueChanged += new System.EventHandler(this.beginInsDatePicker_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Bitiş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Onaylanma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Başlangıç";
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAra.Location = new System.Drawing.Point(709, 113);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 33;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(384, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "RAPOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ProjeAdı";
            // 
            // cmbStates
            // 
            this.cmbStates.FormattingEnabled = true;
            this.cmbStates.Location = new System.Drawing.Point(14, 32);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(224, 21);
            this.cmbStates.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Proje teslim durumları";
            // 
            // txtPrjAdi
            // 
            this.txtPrjAdi.Location = new System.Drawing.Point(101, 75);
            this.txtPrjAdi.Name = "txtPrjAdi";
            this.txtPrjAdi.Size = new System.Drawing.Size(137, 20);
            this.txtPrjAdi.TabIndex = 28;
            // 
            // projeGrid
            // 
            this.projeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projeGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.projeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projeGrid.Location = new System.Drawing.Point(14, 146);
            this.projeGrid.MultiSelect = false;
            this.projeGrid.Name = "projeGrid";
            this.projeGrid.ReadOnly = true;
            this.projeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.projeGrid.Size = new System.Drawing.Size(795, 248);
            this.projeGrid.TabIndex = 27;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 404);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStjAdi);
            this.Controls.Add(this.finishApproveDatePicker);
            this.Controls.Add(this.beginApproveDatePicker);
            this.Controls.Add(this.finishEndDatePicker);
            this.Controls.Add(this.beginEndDatePicker);
            this.Controls.Add(this.finishInsDatePicker);
            this.Controls.Add(this.beginInsDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrjAdi);
            this.Controls.Add(this.projeGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStjAdi;
        private System.Windows.Forms.DateTimePicker finishApproveDatePicker;
        private System.Windows.Forms.DateTimePicker beginApproveDatePicker;
        private System.Windows.Forms.DateTimePicker finishEndDatePicker;
        private System.Windows.Forms.DateTimePicker beginEndDatePicker;
        private System.Windows.Forms.DateTimePicker finishInsDatePicker;
        private System.Windows.Forms.DateTimePicker beginInsDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrjAdi;
        private System.Windows.Forms.DataGridView projeGrid;
    }
}