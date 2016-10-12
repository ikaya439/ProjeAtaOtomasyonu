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
    public partial class ProjeAta : Form
    {
        private Proje projeEntity;
        private Kullanici kullaniciEntity;
        Kullanici stajyerEntity;
        public ProjeAta()
        {
            InitializeComponent();
        }

        private void ProjeAta_Load(object sender, EventArgs e)
        {
            gridDoldur();
            endDate.MinDate = DateTime.Now;
        }

        public void setProje(Proje projeEntity)
        {
            this.projeEntity = projeEntity;
        }
        public Kullanici getStajyer()
        {
            return stajyerEntity;
        }

        public DateTime getEndDate()
        {
            return this.endDate.Value;
        }

        public void gridToEntity()
        {
            if (stajyerEntity == null) { stajyerEntity = new Kullanici(); }
            try
            {
                stajyerEntity.Id = (int)stajyerGrid.CurrentRow.Cells["Id"].Value;
                stajyerEntity = new KullaniciDAOBase().SelectById(stajyerEntity.Id);
            }
            catch (Exception)
            {
                MessageBox.Show("Başarısız");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void screenToEntity()
        {
            if (kullaniciEntity == null) { kullaniciEntity = new Kullanici(); }
            kullaniciEntity.Adi = txtAdi.Text;
            kullaniciEntity.SoyAdi = txtSoyadi.Text;
            kullaniciEntity.Email = txtSoyadi.Text;
            kullaniciEntity.Tel = txtTel.Text;
        }

        private void gridDoldur()
        {
            try
            {
                stajyerGrid.DataSource = new KullaniciDAO().getAllInternWithoutAssignmentForSelectedProject(projeEntity);
                gridInıt();
            }
            catch (Exception) { }
        }
        private void gridDoldur(List<Kullanici> query)
        {
            try
            {
                stajyerGrid.DataSource = query;
                gridInıt();
            }
            catch (Exception) { }
        }

        private void gridInıt()
        {
            stajyerGrid.Columns["Id"].Visible = false;
            stajyerGrid.Columns["ProjeId"].Visible = false;
            stajyerGrid.Columns["AdminStajyer"].Visible = false;
            stajyerGrid.Columns["Active"].Visible = false;
            stajyerGrid.Columns["InsDate"].Visible = false;
            stajyerGrid.Columns["Sifre"].Visible = false;
            for (int i = 0; i < stajyerGrid.Columns.Count; i++)
            {
                stajyerGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            gridToEntity();
            if (endDate.Value == DateTime.MinValue)
            {
                MessageBox.Show("Bitiş tarihi seçin");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            screenToEntity();
            gridDoldur(new KullaniciDAO().SerarchInInternWithoutAssignmentForSelectedProject(projeEntity,kullaniciEntity));
        }

    }
}
