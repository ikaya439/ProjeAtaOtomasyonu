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
    public partial class Calendar : Form
    {
        private DateTime minDate = new DateTime();
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            dateTimePicker.MinDate = minDate;
        }

        public void setDate(DateTime minDate)
        {
            this.minDate = minDate;
        }

        public DateTime getDate()
        {
            return this.dateTimePicker.Value;
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uzatılsın mı ?",
              "Önemli Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;

            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
