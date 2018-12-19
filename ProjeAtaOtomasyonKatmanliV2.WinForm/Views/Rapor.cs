using ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO;
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
    public partial class Rapor : Form
    {
        private List<string> states = new List<string>();
        private Kullanici kullaniciEntity = new Kullanici();
        private Proje projeEntity = new Proje();
        private ProjeSahiplik pSBegin = new ProjeSahiplik();
        private ProjeSahiplik pSFinish = new ProjeSahiplik();
        const int tumProjeler = 0;
        const int teslimEdilmis = 1;
        const int zamanindaOnce = 2;
        const int zamaninda = 3;
        const int zamanindanSonra = 4;
        const int zamanıDolmusVeTeslimEdilmemis = 5;
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            states.Add("Tüm projeler");
            states.Add("Teslim edilmiş projeler");
            states.Add("Zamanından önce teslim edilmiş projeler");
            states.Add("Zamanında teslim edilmiş projeler");
            states.Add("Zamanından sonra teslim edilmiş projeler");
            states.Add("Zamanı dolmuş ve teslim edilmemiş projeler");
            cmbStates.DataSource = states;
            gridDoldur();
        }
        public void setCalisan(Kullanici cModel)
        {
            this.kullaniciEntity = cModel;
        }

        public void gridDoldur()
        {
            try
            {
                projeGrid.Columns.Clear();
                projeGrid.DataSource = new ProjeSahiplikDAO().getAllInternsProjects();
                gridInit();
            }
            catch (Exception e1)
            {
            }
        }

        private void gridDoldur(List<ProjeSahiplik> query)
        {
            try
            {
                projeGrid.Columns.Clear();
                projeGrid.DataSource = query;
                gridInit();
            }
            catch (Exception)
            {
            }
        }

        private void gridInit()
        {
            projeGrid.Columns["Id"].Visible = false;
            projeGrid.Columns["Active"].Visible = false;
            projeGrid.Columns["Path"].Visible = false;
            projeGrid.Columns["StajyerId"].Visible = false;
            projeGrid.Columns["ProjeId"].Visible = false;
            projeGrid.Columns["InsDate"].HeaderText = "BaşlamaTarihi";
            projeGrid.Columns["EndDate"].HeaderText = "BitişTarihi";
            projeGrid.Columns["ApproveDate"].HeaderText = "OnaylanmaTarihi";
            for (int i = 0; i < projeGrid.Columns.Count; i++)
            {
                this.projeGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<ProjeSahiplik> projects = new List<ProjeSahiplik>();
            screenToEntity();
            var a = new ProjeSahiplikDAO().searchInProjeSahiplik(beginInsDatePicker.Checked, beginEndDatePicker.Checked, beginApproveDatePicker.Checked,
                finishInsDatePicker.Checked, finishEndDatePicker.Checked, finishApproveDatePicker.Checked, cmbStates.SelectedIndex, pSBegin, pSFinish,
                projeEntity, kullaniciEntity);
            gridDoldur(a);

        }

        private void screenToEntity()
        {
            kullaniciEntity.Adi = txtStjAdi.Text;
            projeEntity.Adi = txtPrjAdi.Text;
            pSBegin.InsDate = beginInsDatePicker.Value;
            pSBegin.EndDate = beginEndDatePicker.Value;
            pSBegin.ApproveDate = beginApproveDatePicker.Value;
            pSFinish.InsDate = finishInsDatePicker.Value;
            pSFinish.EndDate = finishEndDatePicker.Value;
            pSFinish.ApproveDate = finishApproveDatePicker.Value;
        }

        private void beginInsDatePicker_ValueChanged(object sender, EventArgs e)
        {
            finishInsDatePicker.MinDate = beginInsDatePicker.Value;
        }

        private void beginEndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            finishEndDatePicker.MinDate = beginEndDatePicker.Value;
        }

        private void beginApproveDatePicker_ValueChanged(object sender, EventArgs e)
        {
            finishApproveDatePicker.MinDate = beginApproveDatePicker.Value;
        }
    }
}
