using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO.Base;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using ProjeAtaOtomasyonKatmanliV2.WinForm.Controllers;
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
    public partial class KullaniciDetay : Form
    {
        private Kullanici kullaniciEntity;
        private ProjeSahiplik pSEntity;
        private ProjeVersiyonlari versiyonEntity;
        DataGridViewRow row;
        public KullaniciDetay()
        {
            InitializeComponent();
        }

        private void KullaniciDetay_Load(object sender, EventArgs e)
        {
            lblEMail.Text = kullaniciEntity.Email;
            lblIsim.Text = kullaniciEntity.Adi + " " + kullaniciEntity.SoyAdi;
            lblTel.Text = kullaniciEntity.Tel;
            projeGridDoldur();
        }

        public void setKullanici(Kullanici Entity)
        {
            this.kullaniciEntity = Entity;
        }

        public void projeGridbuttonEkle()
        {
            DataGridViewButtonColumn ac = new DataGridViewButtonColumn();
            ac.Text = "Aç";
            ac.HeaderText = "Aç";
            ac.Width = 25;
            DataGridViewButtonColumn versiyon = new DataGridViewButtonColumn();
            versiyon.Text = "Versiyonlar";
            versiyon.HeaderText = "Versiyonlar";
            versiyon.Width = 75;
            ac.UseColumnTextForButtonValue = versiyon.UseColumnTextForButtonValue = true;
            ProjeGrid.Columns.Add(ac);
            ProjeGrid.Columns.Add(versiyon);
        }

        private void versiyonGridButtonEkle()
        {
            DataGridViewButtonColumn ac = new DataGridViewButtonColumn();
            ac.Text = "Aç";
            ac.HeaderText = "Aç";
            ac.Width = 25;
            ac.UseColumnTextForButtonValue = true;
            versiyonGrid.Columns.Add(ac);
        }

        private void projeGridDoldur()
        {
            try
            {
                ProjeGrid.Columns.Clear();
                ProjeGrid.DataSource = new ProjeSahiplikDAO().getAllProjectsForSelectedIntern(kullaniciEntity);
                ProjeGrid.Columns["Id"].Visible = false;
                ProjeGrid.Columns["ProjeId"].Visible = false;
                ProjeGrid.Columns["StajyerId"].Visible = false;
                ProjeGrid.Columns["Path"].Visible = false;
                ProjeGrid.Columns["Active"].Visible = false; 
                ProjeGrid.Columns["StajyerAdi"].Visible = false;
                ProjeGrid.Columns["InsDate"].HeaderText = "BaşlamaTarihi";
                ProjeGrid.Columns["EndDate"].HeaderText = "BitişTarihi";
                ProjeGrid.Columns["ApproveDate"].HeaderText = "OnaylanmaTarihi";

                for (int i = 0; i < ProjeGrid.Columns.Count; i++)
                {
                    ProjeGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                projeGridbuttonEkle();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

        }
        private void versiyonGridDoldur(List<ProjeVersiyonlari> pS)
        {
            versiyonGrid.Columns.Clear();
            versiyonGrid.DataSource = pS;
            versiyonGrid.Columns["Id"].Visible = false;
            versiyonGrid.Columns["ProjeSahiplikId"].Visible = false;
            versiyonGrid.Columns["Path"].Visible = false;
            versiyonGrid.Columns["Active"].Visible = false;
            for (int i = 0; i < versiyonGrid.Columns.Count; i++)
            {
                versiyonGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            versiyonGridButtonEkle();
        }

        private void versiyonGridToEntity()
        {
            if (versiyonEntity == null) { versiyonEntity = new ProjeVersiyonlari(); }
            versiyonEntity.ProjeSahiplikId = (int)versiyonGrid.CurrentRow.Cells["ProjeSahiplikId"].Value;
            versiyonEntity.Versiyon = versiyonGrid.CurrentRow.Cells["Versiyon"].Value.ToString();
            versiyonEntity.ProjeAdi = versiyonGrid.CurrentRow.Cells["ProjeAdi"].Value.ToString();
        }

        private void projeGridToEntity()
        {
            row = ProjeGrid.CurrentRow;
            if (pSEntity == null) { pSEntity = new ProjeSahiplik(); }
            if (versiyonEntity == null) { versiyonEntity = new ProjeVersiyonlari(); }
            pSEntity.Id = (int)row.Cells["Id"].Value;
            pSEntity = new ProjeSahiplikDAO().SelectById(pSEntity.Id);
            pSEntity.Versiyon = row.Cells["Versiyon"].Value.ToString();
            pSEntity.ProjeAdi = row.Cells["ProjeAdi"].Value.ToString();
            versiyonEntity.ProjeSahiplikId = (int)row.Cells["Id"].Value;
            versiyonEntity.ProjeAdi = row.Cells["ProjeAdi"].Value.ToString();
            versiyonEntity.Versiyon = row.Cells["Versiyon"].Value.ToString();
            if (versiyonEntity.Versiyon != "<yok>")
                versiyonEntity = new ProjeVersiyonlariDAO().SelectOneByOwnerIdAndVersion(versiyonEntity);
            pSEntity.Path = versiyonEntity.Path;
        }

        private void ProjeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 &&
                senderGrid.Columns[e.ColumnIndex].HeaderText == "Aç")
            {
                openLastVersion();
            }
            else if (e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 &&
                senderGrid.Columns[e.ColumnIndex].HeaderText == "Versiyonlar")
            {
                displayVersions();
            }
        }


        private void versiyonGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 &&
                senderGrid.Columns[e.ColumnIndex].HeaderText == "Aç")
            {
                openSelectedVersion();
            }
        }

        private void openLastVersion()
        {
            try
            {
                projeGridToEntity();
                new FileOperations().openProject(pSEntity, true);
            }
            catch (Exception) { }

        }
        private void openSelectedVersion()
        {
            try
            {
                versiyonGridToEntity();
                pSEntity.ProjeAdi = versiyonEntity.ProjeAdi;
                new FileOperations().openProject(pSEntity, true);
            }
            catch (Exception) { }

        }

        private void displayVersions()
        {
            try
            {
                projeGridToEntity();
                versiyonGridDoldur(new ProjeVersiyonlariDAO().getAllInternProjectsVersions(pSEntity));
            }
            catch (Exception) { versiyonGrid.Columns.Clear(); }
        }

        private void ProjeGrid_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = ProjeGrid.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    ProjeGrid.ClearSelection();
                    var hti = ProjeGrid.HitTest(e.X, e.Y);
                    ProjeGrid.Rows[hti.RowIndex].Selected = true;
                    ContextMenuStrip ctxMenu = new ContextMenuStrip();
                    ToolStripMenuItem Uzat = new ToolStripMenuItem("Uzat");
                    ToolStripMenuItem Bitir = new ToolStripMenuItem("Bitir");
                    ToolStripMenuItem Sil = new ToolStripMenuItem("Sil");
                    Uzat.Click += new EventHandler(Uzat_Click);
                    Bitir.Click += new EventHandler(Bitir_Click);
                    Sil.Click += new EventHandler(Sil_Click);
                    ctxMenu.Items.AddRange(new ToolStripItem[] { Bitir, Uzat, Sil });
                    ProjeGrid.ContextMenuStrip = ctxMenu;
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istiyormusunuz ?",
             "Önemli Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                projeGridToEntity();
                new ProjeSahiplikDAO().Delete(pSEntity);
                projeGridDoldur();
            }
        }

        private void Bitir_Click(object sender, EventArgs e)
        {
            projeGridToEntity();
                DialogResult result = MessageBox.Show("Bitirmek istiyormusunuz ?",
                "Önemli Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    pSEntity.ApproveDate = DateTime.Now;
                    try
                    {
                        new ProjeSahiplikDAO().Save(pSEntity);
                        projeGridDoldur();
                    }
                    catch (Exception) { }
                }
        }

        private void Uzat_Click(object sender, EventArgs e)
        {
            projeGridToEntity();

                try
                {
                    Calendar c = new Calendar();
                    c.setDate(pSEntity.InsDate);
                    if (c.ShowDialog() == DialogResult.Yes)
                    {
                        pSEntity.EndDate = c.getDate();
                        new ProjeSahiplikDAO().Save(pSEntity);
                    }
                    projeGridDoldur();
                }
                catch (Exception) { }

        }
    }
}
