using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities.Base
{
    [Serializable]
    public class KullaniciBase
    {
        private int _Id;
        private string _adi;
        private string _soyadi;
        private string _email;
        private string _sifre;
        private string _tel;
        private bool _adminStajyer;
        private bool _active;
        private DateTime _insDate;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }

        public string SoyAdi
        {
            get { return _soyadi; }
            set { _soyadi = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        }

        public bool AdminStajyer
        {
            get { return _adminStajyer; }
            set { _adminStajyer = value; }
        }

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public DateTime InsDate
        {
            get { return _insDate; }
            set { _insDate = value; }
        }


    }
}
