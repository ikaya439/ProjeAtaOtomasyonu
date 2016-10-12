using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities.Base
{
    [Serializable]
    public class ProjeVersiyonlariBase
    {
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
        private string _versiyon;

        public string Versiyon
        {
            get { return _versiyon; }
            set { _versiyon = value; }
        }
        private int _projeSahiplikId;

        public int ProjeSahiplikId
        {
            get { return _projeSahiplikId; }
            set { _projeSahiplikId = value; }
        }
        private bool _active;

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
        private DateTime _insDate;

        public DateTime InsDate
        {
            get { return _insDate; }
            set { _insDate = value; }
        }

    }
}
