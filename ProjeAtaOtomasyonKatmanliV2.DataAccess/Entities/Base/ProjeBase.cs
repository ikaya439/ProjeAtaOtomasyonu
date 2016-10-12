using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities.Base
{
    [Serializable]
    public class ProjeBase
    {
        private int _id;
        private string _adi;
        private string _konu;
        private string _tanitim;
        private bool _active;
        private DateTime _insDate;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }

        public string Konu
        {
            get { return _konu; }
            set { _konu = value; }
        }

        public string Tanitim
        {
            get { return _tanitim; }
            set { _tanitim = value; }
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
