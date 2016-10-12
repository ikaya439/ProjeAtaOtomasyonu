using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO
{
    public class ProjeVersiyonlariDAO : Base.ProjeVersiyonlariDAOBase
    {
        public ProjeVersiyonlariDAO() : base()
        {
        }
        public List<ProjeVersiyonlari> getAllInternProjectsVersions(ProjeSahiplik projeSahiplikEntity)
        {
            string select = "select p.Adi ,pV.* ";
            string from = "from Proje p join ProjeSahiplik pS on p.Id = pS.ProjeId join ProjeVersiyonlari pV on pS.Id = pV.ProjeSahiplikId ";
            string where = " where pS.Id = @ProjeSahiplikId and pV.Active = @Active";
            string query = select + from + where;
            IDbCommand cmd = this.CreateCommand(query);
            AddParameter(cmd, "@Active", true);
            AddParameter(cmd, "@ProjeSahiplikId", projeSahiplikEntity.Id);
            List<ProjeVersiyonlari> a = SelectCompact(cmd).Cast<ProjeVersiyonlari>().ToList();
            return a;
        }
        public ProjeVersiyonlari SelectOneByOwnerIdAndVersion(ProjeVersiyonlari pVEntity)
        {
            IDbCommand cmd = this.CreateCommand("");
            string select = "select top 1 * ";
            string from = "from ProjeVersiyonlari pV ";
            string where = " where pV.ProjeSahiplikId=@SahiplikId and pV.Versiyon=@Versiyon ";
            string query = select + from + where;

            AddParameter(cmd, "@SahiplikId", pVEntity.ProjeSahiplikId);
            AddParameter(cmd, "@Versiyon", pVEntity.Versiyon);
            cmd.CommandText = query;
            return SelectOne(cmd);
        }
    }
}
