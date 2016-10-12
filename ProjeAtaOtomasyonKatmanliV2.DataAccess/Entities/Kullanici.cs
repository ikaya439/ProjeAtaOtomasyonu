using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities
{
    public class Kullanici : Base.KullaniciBase
    {
        private int _projeId;

        public int ProjeId
        {
            get { return _projeId; }
            set { _projeId = value; }
        }

    }
}
