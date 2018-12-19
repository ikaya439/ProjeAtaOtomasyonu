using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using ProjeAtaOtomasyonKatmanliV2.WinForm.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtaOtomasyonKatmanliV2.WinForm.Views
{
    public partial class Stajyer : Form
    {
        private ProjeSahiplik pSEntity;
        private Kullanici Entity = new Kullanici();
        public Stajyer()
        {
            InitializeComponent();
        }

        private void Stajyer_Load(object sender, EventArgs e)
        {
            gridDoldur();
            lblKullaniciAdi.Text = "Hoşgeldin" + " " + Entity.Adi + " " + Entity.SoyAdi;
        }

        public void setStajyer(Kullanici Entity)
        {
            this.Entity = Entity;
        }

        private void gridButtonEkle()
        {
            DataGridViewButtonColumn ac = new DataGridViewButtonColumn();
            ac.Text = "Aç";
            ac.HeaderText = "Aç";
            ac.UseColumnTextForButtonValue = true;
            projeGrid.Columns.Add(ac);

            DataGridViewButtonColumn guncelle = new DataGridViewButtonColumn();
            guncelle.Text = "Güncelle";
            guncelle.HeaderText = "Güncelle";
            guncelle.UseColumnTextForButtonValue = true;
            projeGrid.Columns.Add(guncelle);
        }

        private void gridDoldur()
        {
            try
            {
                projeGrid.Columns.Clear();
                List<ProjeSahiplik> ps = new ProjeSahiplikDAO().getAllProjectsForSelectedIntern(Entity);
                projeGrid.DataSource = ps;

                projeGrid.Columns["Id"].Visible = false;
                projeGrid.Columns["StajyerId"].Visible = false;
                projeGrid.Columns["Path"].Visible = false;
                projeGrid.Columns["StajyerAdi"].Visible = false;
                projeGrid.Columns["ProjeId"].Visible = false;
                projeGrid.Columns["Active"].Visible = false;
                for (int i = 0; i < projeGrid.ColumnCount; i++)
                {
                    this.projeGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                gridButtonEkle();
            }
            catch { }
        }

        private void projeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                senderGrid.Columns[e.ColumnIndex].HeaderText == "Aç")
            {
                ac();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                senderGrid.Columns[e.ColumnIndex].HeaderText == "Güncelle")
            {
                guncelle();
            }
        }

        private void ac()
        {
            screenToEntity();
            try
            {
                new FileOperations().openProject(pSEntity, false);
                gridDoldur();
            }
            catch (Exception e1) { }
        }

        private void guncelle()
        {
            screenToEntity();
            FileOperations fop = new FileOperations();
            fop.updateProject(pSEntity);
            gridDoldur();
        }

        private void screenToEntity()
        {
            if (pSEntity == null) { pSEntity = new ProjeSahiplik(); }
            pSEntity.Id = (int)projeGrid.CurrentRow.Cells["Id"].Value;
            pSEntity = new ProjeSahiplikDAO().SelectById(pSEntity.Id);
            pSEntity.Versiyon = projeGrid.CurrentRow.Cells["Versiyon"].Value.ToString();
            pSEntity.ProjeAdi = projeGrid.CurrentRow.Cells["ProjeAdi"].Value.ToString();
        }
    }
}
