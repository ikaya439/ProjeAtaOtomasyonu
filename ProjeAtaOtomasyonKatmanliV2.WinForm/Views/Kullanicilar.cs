using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using ProjeAtaOtomasyonKatmanliV2.WinForm.Views;
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
    public partial class Kullanicilar : Form
    {
        private bool calisanStajyer;
        public Kullanici Entity;
        private KullaniciDAO kDAO = new KullaniciDAO();
        public Kullanicilar()
        {
            InitializeComponent();
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }
        public void setCalisanStajyerState(bool calisanStajyer)
        {
            this.calisanStajyer = calisanStajyer;
        }

        public void button()
        {
            DataGridViewButtonColumn duzenle = new DataGridViewButtonColumn();
            duzenle.Text = "Düzenle";
            duzenle.HeaderText = "Düzenle";
            duzenle.Width = 75;
            DataGridViewButtonColumn sil = new DataGridViewButtonColumn();
            sil.Text = "Sil";
            sil.HeaderText = "Sil";
            sil.Width = 40;

            if (!calisanStajyer)
            {
                DataGridViewButtonColumn detay = new DataGridViewButtonColumn();
                detay.Text = "Detay";
                detay.HeaderText = "Detay";
                detay.Width = 50;
                detay.UseColumnTextForButtonValue = true;
                kullanicilarGrid.Columns.Add(detay);
            }
            duzenle.UseColumnTextForButtonValue = sil.UseColumnTextForButtonValue = true;
            kullanicilarGrid.Columns.Add(duzenle);
            kullanicilarGrid.Columns.Add(sil);
        }

        private void kullanicilarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                senderGrid.Columns[e.ColumnIndex].HeaderText == "Düzenle")
            {
                duzenle();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                senderGrid.Columns[e.ColumnIndex].HeaderText == "Sil")
            {
                sil();
                gridDoldur();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
               senderGrid.Columns[e.ColumnIndex].HeaderText == "Detay")
            {
                detayAc();
            }
        }

        private void detayAc()
        {
            KullaniciDetay kD = new KullaniciDetay();
            gridToEntity();
            kD.setKullanici(Entity);
            kD.Show();
        }

        private void sil()
        {
            gridToEntity();
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Silinsin mi?", "Uyarı!", MessageBoxButtons.YesNo))
                {
                    kDAO.Delete(Entity);
                    MessageBox.Show("Silindi");
                    gridDoldur();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void duzenle()
        {
            gridToEntity();
            Kullanici TempEntity = Entity;
            KullaniciEkleDuzenle kED = new KullaniciEkleDuzenle();
            kED.setState("Düzenle");
            kED.setEntity(Entity);
            DialogResult result = kED.ShowDialog();
            if (result.CompareTo(DialogResult.OK) == 0)
            {
                Entity = kED.getEntity();
                if (!new KullaniciDAO().existingControl(Entity))
                {
                    Entity.AdminStajyer = calisanStajyer;
                    try
                    {
                        kDAO.Save(Entity);
                        MessageBox.Show("Düzenlendi");
                        gridDoldur();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Başarısız");
                    }
                }
                else
                {
                    MessageBox.Show("Mevcut kullanici");
                }
            }
        }

        private void gridToEntity()
        {
            if (Entity == null) { Entity = new Kullanici(); }
            DataGridViewRow row = kullanicilarGrid.CurrentRow;
            Entity.Id = (int)row.Cells["Id"].Value;
            Entity.Adi = row.Cells["Adi"].Value.ToString();
            Entity.SoyAdi = row.Cells["SoyAdi"].Value.ToString();
            Entity.Email = row.Cells["Email"].Value.ToString();
            Entity.Tel = row.Cells["Tel"].Value.ToString();
            Entity.Sifre = row.Cells["Sifre"].Value.ToString();
            Entity.AdminStajyer = Convert.ToBoolean(row.Cells["AdminStajyer"].Value);
            Entity.Active = Convert.ToBoolean(row.Cells["Active"].Value);
            Entity.InsDate = Convert.ToDateTime(row.Cells["InsDate"].Value);
        }

        private void gridDoldur()
        {
            kullanicilarGrid.Columns.Clear();
            kullanicilarGrid.DataSource = kDAO.SelectAllUserByCalisanStajyerState(this.calisanStajyer);
            gridInit();
        }

        public void gridDoldur(List<Kullanici> query)
        {
            kullanicilarGrid.Columns.Clear();
            kullanicilarGrid.DataSource = query;
            gridInit();
        }

        private void gridInit()
        {
            kullanicilarGrid.Columns["InsDate"].HeaderText = "BaşlamaTarihi";
            kullanicilarGrid.Columns["Id"].Visible = false;
            kullanicilarGrid.Columns["Sifre"].Visible = false;
            kullanicilarGrid.Columns["AdminStajyer"].Visible = false;
            kullanicilarGrid.Columns["ProjeId"].Visible = false;
            kullanicilarGrid.Columns["Active"].Visible = false;
            for (int i = 0; i < kullanicilarGrid.Columns.Count; i++)
            {
                kullanicilarGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            button();
        }

        private void ScreenToEntity()
        {
            if (Entity == null) { Entity = new Kullanici(); }
            Entity.Adi = txtAdi.Text;
            Entity.SoyAdi = txtSoyadi.Text;
            Entity.Email = txtEmail.Text;
            Entity.Tel = txtTel.Text;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                ScreenToEntity();
                Entity.AdminStajyer = calisanStajyer;
                var a = kDAO.SearchInUsers(Entity);
                gridDoldur(a);
            }
            catch (Exception)
            {
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            KullaniciEkleDuzenle kED = new KullaniciEkleDuzenle();
            DialogResult result = kED.ShowDialog();
            if (result.CompareTo(DialogResult.OK) == 0)
            {
                Entity = kED.getEntity();
                if (!new KullaniciDAO().existingControl(Entity))
                {
                    Entity.Active = true;
                    Entity.InsDate = DateTime.Now;
                    Entity.AdminStajyer = calisanStajyer;
                    try
                    {
                        kDAO.Save(Entity);
                        MessageBox.Show("Eklendi");
                        gridDoldur();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Başarısız");
                    }
                }
                else
                {
                    MessageBox.Show("Mevcut kullanici");
                }
            }
        }
    }
}
