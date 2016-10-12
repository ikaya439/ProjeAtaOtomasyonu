using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO.Base;
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
    public partial class Projeler : Form
    {
        Proje projeEntity;
        Kullanici stajyerEntity;
        public Projeler()
        {
            InitializeComponent();
        }

        private void Projeler_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void gridToEntity()
        {
            if (projeEntity == null) { projeEntity = new Proje(); }
            DataGridViewRow row = projeGrid.CurrentRow;
            projeEntity = new ProjeDAOBase().SelectById((int)row.Cells["Id"].Value);
        }
        private void screenToEntity()
        {
            if (projeEntity == null) { projeEntity = new Proje(); }
            projeEntity.Adi = txtAdi.Text;
            projeEntity.Konu = txtKonu.Text;
            projeEntity.Tanitim = txtTanitim.Text;
        }

        public void button()
        {
            DataGridViewButtonColumn ata = new DataGridViewButtonColumn();
            ata.Text = "Ata";
            ata.HeaderText = "Ata";
            ata.Width = 40;
            DataGridViewButtonColumn duzenle = new DataGridViewButtonColumn();
            duzenle.Text = "Düzenle";
            duzenle.HeaderText = "Düzenle";
            duzenle.Width = 75;
            DataGridViewButtonColumn sil = new DataGridViewButtonColumn();
            sil.Text = "Sil";
            sil.HeaderText = "Sil";
            sil.Width = 40;
            ata.UseColumnTextForButtonValue = duzenle.UseColumnTextForButtonValue = sil.UseColumnTextForButtonValue = true;
            projeGrid.Columns.Add(ata);
            projeGrid.Columns.Add(duzenle);
            projeGrid.Columns.Add(sil);
        }

        private void gridDoldur()
        {
            projeGrid.Columns.Clear();
            var a = new ProjeDAOBase().SelectAll();
            a = a.Where(w => w.Active == true).ToList<Proje>();
            projeGrid.DataSource = a;
            gridInit();
        }
        private void gridDoldur(List<Proje> projects)
        {
            projeGrid.Columns.Clear();
            var a = new ProjeDAOBase().SelectAll();
            a = a.Where(w => w.Active == true).ToList<Proje>();
            projeGrid.DataSource = projects;
            gridInit();
        }
        private void gridInit()
        {
            projeGrid.Columns["Id"].Visible = false;
            projeGrid.Columns["Active"].Visible = false;
            for (int i = 0; i < projeGrid.Columns.Count; i++)
            {
                projeGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            button();
        }
        private void projeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
               senderGrid.Columns[e.ColumnIndex].HeaderText == "Ata")
            {
                projeAta();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
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
        }

        private void projeAta()
        {
            ProjeAta pAta = new ProjeAta();
            gridToEntity();
            pAta.setProje(projeEntity);
            pAta.ShowDialog();

            if (pAta.DialogResult == DialogResult.OK)
            {
                try
                {
                    stajyerEntity = pAta.getStajyer();
                    DateTime EndDate = pAta.getEndDate();
                    ProjeSahiplik pSEntity = new ProjeSahiplik();
                    pSEntity.Active = true;
                    pSEntity.EndDate = EndDate;
                    pSEntity.InsDate = DateTime.Now;
                    pSEntity.ProjeId = projeEntity.Id;
                    pSEntity.StajyerId = stajyerEntity.Id;
                    new ProjeSahiplikDAOBase().Save(pSEntity);
                    MessageBox.Show("Başarılı");
                }
                catch (Exception)
                {
                }
            }
        }

        private void sil()
        {
            gridToEntity();
            try
            {
                projeEntity.Active = false;
                new ProjeDAOBase().Save(projeEntity);
                gridDoldur();
                MessageBox.Show("Silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void duzenle()
        {
            ProjeEkleDuzenle pED = new ProjeEkleDuzenle();
            gridToEntity();
            pED.setProje(projeEntity);
            pED.setState = "Düzenle";
            if (pED.ShowDialog() == DialogResult.OK)
            {
                if (!new ProjeDAO().existingControl(projeEntity))
                {
                    try
                    {
                        new ProjeDAOBase().Save(projeEntity);
                        MessageBox.Show("Duzenlendi");
                        gridDoldur();
                    }
                    catch (Exception) { }
                }
                else
                {
                    MessageBox.Show("Mevcut proje");
                }
            }

        }

        private void btnYeniProje_Click(object sender, EventArgs e)
        {
            ProjeEkleDuzenle pED = new ProjeEkleDuzenle();
            if (pED.ShowDialog() == DialogResult.OK)
            {
                projeEntity = pED.getProje();
                if (!new ProjeDAO().existingControl(projeEntity))
                {
                    projeEntity.Active = true;
                    projeEntity.InsDate = DateTime.Now;
                    try
                    {
                        new ProjeDAOBase().Save(projeEntity);
                        MessageBox.Show("Kaydedildi");
                        gridDoldur();
                    }
                    catch (Exception) { }
                }
                else
                {
                    MessageBox.Show("Mevcut proje");
                }

            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            screenToEntity();
            try
            {
                gridDoldur(new ProjeDAO().SearchInProjects(projeEntity));
            }
            catch (Exception)
            {
            }
        }
    }
}
