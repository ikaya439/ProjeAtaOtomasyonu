using ProjeAtaOtomasyonKatmanliV2.DataAccess;
using ProjeAtaOtomasyonKatmanliV2.WinForm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeAtaOtomasyonKatmanliV2.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());
        }
    }
}
