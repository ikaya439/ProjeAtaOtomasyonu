using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtamaOtomasyonuV2.Controllers
{
    class AlanController
    {
        Control.ControlCollection Controls;
        internal void setControls(Control.ControlCollection Controls)
        {
            this.Controls = Controls;
        }
        public bool boslukKontrol()
        {
            foreach (Control c in Controls)
            {
                if ((c is TextBox || c is RichTextBox) && string.IsNullOrWhiteSpace(c.Text))
                {
                    MessageBox.Show("Boşluk girilemez!!!");
                    return false;
                }
            }
            return true;
        }
        public bool alanTemizle()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is RichTextBox)
                {
                    c.Text = "";
                }
            }
            return true;
        }
        public bool emailKontrol(TextBox txtEmail)
        {
            int sayac = 0;
            for (int i = 0; i < txtEmail.Text.Length - 3; i++)
            {
                if (txtEmail.Text.Substring(i, 4) == ".com" && txtEmail.Text.Substring(i - 1, 1) != "@")
                {
                    sayac++;
                }
                if (txtEmail.Text.Substring(i, 1) == "@")
                {
                    sayac++;
                }
            }//yazilimindunyasi.com
            if (sayac == 2)
            {
                return true;
            }//yazilimindunyasi.com
            else
            {
                return false;
            }
        }
        public void deleteInitalSpaceChar()
        {
            int count = 0;
            foreach (Control c in Controls)
            {
                if (c is TextBox || c is RichTextBox)
                {
                    for (int i = 0; i < c.Text.Length; i++)
                    {
                        if (c.Text[i] == ' ')
                        {
                            count++;
                        }
                        else
                            break;
                    }
                    if (!string.IsNullOrWhiteSpace(c.Text)&&c.Text.Length>1)
                    {
                        string t = c.Text.Substring(count, c.Text.Length-count);
                        c.Text = t;
                    }
                }
            }
        }
    }
}
