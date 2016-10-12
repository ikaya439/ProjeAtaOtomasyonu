using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities
{
    public class ProjeVersiyonlari : Base.ProjeVersiyonlariBase
    {
        public ProjeVersiyonlari() : base()
        {
        }

        private string _adi;

        public string ProjeAdi
        {
            get { return _adi; }
            set { _adi = value; }
        }
    }
}
