using ProjeAtamaOtomasyonuV2.Controllers;
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

namespace ProjeAtaOtomasyonKatmanliV2.WinForm
{
    public partial class KullaniciEkleDuzenle : Form
    {
        private Kullanici Entity = new Kullanici();
        private AlanController aC = new AlanController();
        private string state;
        public KullaniciEkleDuzenle()
        {
            InitializeComponent();
        }


        private void KullaniciEkleDuzenle_Load(object sender, EventArgs e)
        {
            aC.setControls(this.Controls);
            lblHata.Text = "";
            lblHata.Location = new Point(this.Width / 3, this.Height / 13);
            if (state == "Düzenle")
            {
                duzenlemeAlaninaDon();
            }
        }

        public void setState(string state)
        {
            this.state = state;
        }

        public void setEntity(Kullanici Entity)
        {
            this.Entity = Entity;
            entityToScreen();
        }

        public Kullanici getEntity()
        {
            screenToEntity();
            return Entity;
        }

        private void screenToEntity()
        {
            aC.deleteInitalSpaceChar();
            Entity.Adi = txtAdi.Text;
            Entity.SoyAdi = txtSoyadi.Text;
            Entity.Email = txtEmail.Text;
            Entity.Tel = txtTel.Text;
            Entity.Sifre = txtSifre.Text;
        }

        private void entityToScreen()
        {
            txtAdi.Text = Entity.Adi;
            txtSoyadi.Text = Entity.SoyAdi;
            txtEmail.Text = Entity.Email;
            txtTel.Text = Entity.Tel;
            txtSifre.Text = Entity.Sifre;
        }

        private void duzenlemeAlaninaDon()
        {
            lblGiris.Text = state;
            btnEkleDuzenle.Text = state;
        }

        private void btnEkleDuzenle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdi.Text) || string.IsNullOrWhiteSpace(txtSoyadi.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
                lblHata.Text = "Boşluk Girilemez";
            else if (!aC.emailKontrol(txtEmail))
            {
                lblHata.Text = "Email Hatalı";
            }
            else if(state=="Düzenle"&& compareScreenAndEntity())
            {
                this.DialogResult = DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool compareScreenAndEntity()
        {
            if (Entity.Adi == txtAdi.Text && Entity.SoyAdi == txtSoyadi.Text && Entity.Email == txtEmail.Text 
                && Entity.Tel == txtTel.Text && Entity.Sifre == txtSifre.Text)
                return true;
            return false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtAlp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
