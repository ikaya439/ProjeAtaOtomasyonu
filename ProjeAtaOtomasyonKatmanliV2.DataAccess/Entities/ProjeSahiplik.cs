using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities
{
    public class ProjeSahiplik : Base.ProjeSahiplikBase
    {
        private string _adi;

        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }

        private string _konu;

        public string Konu
        {
            get { return _konu; }
            set { _konu = value; }
        }

        private string _versiyon;

        public string Versiyon
        {
            get { return _versiyon; }
            set { _versiyon = value; }
        }

        private string _stajyer;

        public string Stajyer
        {
            get { return _stajyer; }
            set { _stajyer = value; }
        }
    }
}
