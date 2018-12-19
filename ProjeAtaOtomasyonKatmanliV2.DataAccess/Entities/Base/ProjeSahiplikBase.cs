using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities.Base
{
    [Serializable]
    public class ProjeSahiplikBase
    {
        public ProjeSahiplikBase()
        {
            _approveDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private int _projeId;

        public int ProjeId
        {
            get { return _projeId; }
            set { _projeId = value; }
        }

        private int _stajyerId;

        public int StajyerId
        {
            get { return _stajyerId; }
            set { _stajyerId = value; }
        }
        private DateTime _insDate;

        public DateTime InsDate
        {
            get { return _insDate; }
            set { _insDate = value; }
        }
        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        private DateTime _approveDate;

        public DateTime ApproveDate
        {
            get { return _approveDate; }
            set { _approveDate = value; }
        }
        private bool _active;

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }



    }
}
