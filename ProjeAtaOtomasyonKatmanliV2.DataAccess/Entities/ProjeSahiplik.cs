using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities
{
    public class ProjeSahiplik : Base.ProjeSahiplikBase
    {
        private string _projeAdi;

        public string ProjeAdi
        {
            get { return _projeAdi; }
            set { _projeAdi = value; }
        }

        private string _versiyon;

        public string Versiyon
        {
            get { return _versiyon; }
            set { _versiyon = value; }
        }

        private string _stajyerAdi;

        public string StajyerAdi
        {
            get { return _stajyerAdi; }
            set { _stajyerAdi = value; }
        }
    }
}
