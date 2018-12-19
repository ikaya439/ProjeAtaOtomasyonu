using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;
using ProjeAtamaOtomasyonuV2.Controllers;
using ProjeAtaOtomasyonKatmanliV2.WinForm;
using ProjeAtaOtomasyonKatmanliV2.WinForm.Views;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess
{
    public partial class Giris : Form
    {
        private Kullanicilar kullanicilar;
        public Kullanici Entity;
        string strYeniKayit = "Yeni Kayıt";
        string strGiris = "Giriş";
        string strBaslik = "Giriş";
        Point baslikDefaultPosition = new Point(180, 180);
        Point baslikNextPosition = new Point(180, 100);
        AlanController aC = new AlanController();
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            aC.setControls(this.Controls);
            baslikNextPosition = new Point(this.Width / 2, this.Height / 12);
            baslikDefaultPosition = new Point(this.Width / 2, this.Height / 4);
            lblBaslik.Location = baslikDefaultPosition;
        }

        private void ScreenToEntity()
        {
            aC.deleteInitalSpaceChar();
            if (Entity == null) { Entity = new Kullanici(); }

            if (strGiris == "Giriş" || aC.boslukKontrol())
            {
                Entity.Adi = txtAdi.Text;
                Entity.SoyAdi = txtSoyadi.Text;
                Entity.Email = txtEmail.Text;
                Entity.Tel = txtTel.Text;
                Entity.Sifre = txtSifre.Text;
                Entity.Active = true;
                Entity.AdminStajyer = false;
                Entity.InsDate = DateTime.Now;
            }
        }
        private void EntityToScreen(Kullanici entity)
        {
            Entity = entity;
            if (entity == null)
            {
                txtAdi.Clear();
                txtSoyadi.Clear();
                txtEmail.Clear();
                txtTel.Clear();
                txtSifre.Clear();
            }
        }
        private void kaydetmeAlaninaDon()
        {
            EntityToScreen(null);
            lblAdi.Visible = true;
            lblSoyAdi.Visible = true;
            lblTel.Visible = true;
            txtAdi.Visible = true;
            txtSoyadi.Visible = true;
            txtTel.Visible = true;

            strYeniKayit = "Kaydet";
            strGiris = "İptal";
            strBaslik = "Kaydet";

            lblBaslik.Text = strBaslik;
            lblBaslik.Location = baslikNextPosition;
            btnYeniKayit.Text = strYeniKayit;
            btnGiris.Text = strGiris;
            //  lblSifre.Location = new Point(lblSifre.Location.X, lblSifre.Location.Y+25);
        }
        private void girisAlaninaDon()
        {
            lblAdi.Visible = false;
            lblSoyAdi.Visible = false;
            lblTel.Visible = false;
            txtAdi.Visible = false;
            txtSoyadi.Visible = false;
            txtTel.Visible = false;

            strYeniKayit = "Yeni Kayıt";
            strGiris = "Giriş";
            strBaslik = "Giriş";

            lblBaslik.Text = strBaslik;
            lblBaslik.Location = baslikDefaultPosition;
            btnYeniKayit.Text = strYeniKayit;
            btnGiris.Text = strGiris;

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (strYeniKayit == "Kaydet")
            {
                if (aC.boslukKontrol() && aC.emailKontrol(txtEmail))
                {
                    ScreenToEntity();
                    if (new KullaniciDAO().SelectOneUserByEmailAndPhone(Entity) == null)
                    {
                        try
                        {
                            new KullaniciDAO().Save(Entity);
                            MessageBox.Show("Kaydedildi");
                            EntityToScreen(null);
                            girisAlaninaDon();
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.ToString());
                        }
                    }
                    else MessageBox.Show("Kullanıcı mevcut");
                }

            }
            else if (strYeniKayit == "Yeni Kayıt")
            {
                kaydetmeAlaninaDon();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (strGiris == "Giriş")
            {
                if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtSifre.Text))
                {
                    ScreenToEntity();
                    Kullanici exist = new KullaniciDAO().SelectOneUserByEmailAndPassword(Entity);
                    if (exist != null)
                    {
                        EntityToScreen(null);
                        kullanicilar = new Kullanicilar();
                        if (exist.AdminStajyer)
                        {
                            kullanicilar.setCalisanStajyerState(true);
                            AnaSayfa a = new AnaSayfa();
                            a.FormClosed += (s, args) => this.Show();
                            this.Hide();
                            a.Show();
                        }
                        else
                        {
                            Stajyer stj = new Stajyer();
                            stj.setStajyer(exist);
                            stj.FormClosed += (s, args) => this.Show();
                            this.Hide();
                            stj.Show();
                        }
                    }
                    else
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış");

                }
                else
                {
                    MessageBox.Show("Boşluk girilemez");
                }
            }
            else if (strGiris == "İptal")
            {
                girisAlaninaDon();
            }
            //      aC.alanTemizle();
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
