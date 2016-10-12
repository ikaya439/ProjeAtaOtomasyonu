using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtaOtomasyonKatmanliV2.WinForm.Views
{
    public partial class ProjeEkleDuzenle : Form
    {
        private string state;
        Proje Entity;
        public ProjeEkleDuzenle()
        {
            InitializeComponent();
        }

        private void ProjeEkleDuzenle_Load(object sender, EventArgs e)
        {
            if (state == "Düzenle")
            {
                duzenlemeAlaninaDon();
                entityToScreen();
            }
        }
        public string setState
        {
            set
            {
                state = value;
            }
        }
        public void setProje(Proje Entity)
        {
            this.Entity = Entity;
        }
        public Proje getProje()
        {
            return Entity;
        }
        public void duzenlemeAlaninaDon()
        {
            lblGiris.Text = "Proje Duzenle";
            this.Text = "Proje Duzenle";
            btnEkleDuzenle.Text = "Düzenle";
        }

        private void screenToEntity()
        {
            if (Entity == null) { Entity = new Proje(); }
            Entity.Adi = txtProjeAdi.Text;
            Entity.Konu = rchTxtProjeKonu.Text;
            Entity.Tanitim = rchTxtProjeTanitim.Text;
        }

        private void entityToScreen()
        {
            txtProjeAdi.Text = Entity.Adi;
            rchTxtProjeKonu.Text = Entity.Konu;
            rchTxtProjeTanitim.Text = Entity.Tanitim;
        }

        private void btnEkleDuzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProjeAdi.Text) && !string.IsNullOrWhiteSpace(rchTxtProjeTanitim.Text) && !string.IsNullOrWhiteSpace(rchTxtProjeKonu.Text) )
            {
                if (Entity == null)
                {
                    screenToEntity();
                    this.DialogResult = DialogResult.OK;
                }
                else if (txtProjeAdi.Text == Entity.Adi && rchTxtProjeTanitim.Text == Entity.Tanitim && rchTxtProjeKonu.Text == Entity.Konu)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    screenToEntity();
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Boşluk girilemez");
            }
        }

    }
}
