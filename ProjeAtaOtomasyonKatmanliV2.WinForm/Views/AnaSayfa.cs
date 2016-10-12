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
    public partial class AnaSayfa : Form
    {

        Kullanicilar calisanlar;
        Kullanicilar stajyerler;
        Projeler projeler;
        Rapor rapor;

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Menu.Cursor = Cursors.Hand;
        }

        private void btnCalisan_Click(object sender, EventArgs e)
        {
            if (calisanlar == null) { calisanlar = new Kullanicilar(); }
            calisanlar.setCalisanStajyerState(true);
            menuItemClickInıt(calisanlar);
        }

        private void btnStajyer_Click(object sender, EventArgs e)
        {
            if (stajyerler == null) { stajyerler = new Kullanicilar(); }
            stajyerler.setCalisanStajyerState(false);
            menuItemClickInıt(stajyerler);
        }


        private void btnProje_Click(object sender, EventArgs e)
        {
            if (projeler == null) { projeler = new Projeler(); }
            menuItemClickInıt(projeler);
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            if (rapor == null) { rapor = new Rapor(); }
            rapor.gridDoldur();
            menuItemClickInıt(rapor);
        }

        private void menuItemClickInıt(Form f)
        {
            f.Activate();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
