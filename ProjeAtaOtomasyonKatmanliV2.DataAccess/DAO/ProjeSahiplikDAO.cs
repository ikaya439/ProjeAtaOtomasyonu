using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO
{
    public class ProjeSahiplikDAO : Base.ProjeSahiplikDAOBase
    {
        const int tumProjeler = 0;
        const int teslimEdilmis = 1;
        const int zamanindaOnce = 2;
        const int zamaninda = 3;
        const int zamanindanSonra = 4;
        const int zamanıDolmusVeTeslimEdilmemis = 5;
        public ProjeSahiplikDAO() : base()
        {

        }

        public List<ProjeSahiplik> getAllProjectsForSelectedIntern(Kullanici Entity)
        {
            IDbCommand cmd;
            string query = "";
            string select = "select pKS.Id, pKS.ProjeAdi as [Adi],pKS.ProjeId,pKS.StajyerId ,pKS.StajyerAdi as [Stajyer] ,"
                + "MAX(pV.Versiyon) as [Versiyon],pKS.Active,pKS.EndDate,pKS.ApproveDate,pKS.InsDate ";
            string from = " from (select pS.* , p.Adi as[ProjeAdi], k.Adi as [StajyerAdi] from Kullanici k join ProjeSahiplik pS on k.Id = pS.StajyerId " +
                            "join Proje p on pS.ProjeId = p.Id ) as pKS left join ProjeVersiyonlari pV on pKS.Id = pV.ProjeSahiplikId  ";
            string where = " where pKS.Active = 1 and  pKS.StajyerId=@StajyerId";
            string groupBy = " group by pKS.Id,pKS.ApproveDate,pKS.InsDate,pKS.EndDate,pKS.ProjeAdi,pKS.StajyerAdi,pKS.ProjeId,pKS.StajyerId,pKS.Active";

            query += select + from + where + groupBy;
            cmd = this.CreateCommand(query);
            AddParameter(cmd, "@StajyerId", Entity.Id);
            AddParameter(cmd, "@Active", true);
            return SelectCompact(cmd).ToList();
        }

        public List<ProjeSahiplik> getAllInternsProjects()
        {
            IDbCommand cmd;
            string query = "";
            string select = "select pKS.Id, pKS.ProjeAdi as [Adi],pKS.ProjeId,pKS.StajyerId ,pKS.StajyerAdi as [Stajyer] ,"
                + "MAX(pV.Versiyon) as [Versiyon],pKS.Active,pKS.EndDate,pKS.ApproveDate,pKS.InsDate ";
            string from = " from (select pS.* , p.Adi as[ProjeAdi], k.Adi as [StajyerAdi] from Kullanici k join ProjeSahiplik pS on k.Id = pS.StajyerId " +
                            "join Proje p on pS.ProjeId = p.Id ) as pKS left join ProjeVersiyonlari pV on pKS.Id = pV.ProjeSahiplikId  ";
            string where = " where pKS.Active = 1 ";
            string groupBy = " group by pKS.Id,pKS.ApproveDate,pKS.InsDate,pKS.EndDate,pKS.ProjeAdi,pKS.StajyerAdi,pKS.ProjeId,pKS.StajyerId,pKS.Active";

            query += select + from + where + groupBy;
            cmd = this.CreateCommand(query);
            AddParameter(cmd, "@Active", true);
            return SelectCompact(cmd).ToList();
        }

        public List<ProjeSahiplik> getAllInternProjects(Kullanici kullaniciEntity, Proje projeEntity)
        {

            IDbCommand cmd;

            string query = "";
            string select = "select pKS.Id, pKS.ProjeAdi as [Adi],pKS.ProjeId,pKS.StajyerId ,pKS.StajyerAdi as [Stajyer] ,"
                + "MAX(pV.Versiyon) as [Versiyon],pKS.Active,pKS.EndDate,pKS.ApproveDate,pKS.InsDate ";
            string from = " from (select pS.* , p.Adi as[ProjeAdi], k.Adi as [StajyerAdi] from Kullanici k join ProjeSahiplik pS on k.Id = pS.StajyerId " +
                            "join Proje p on pS.ProjeId = p.Id ) as pKS left join ProjeVersiyonlari pV on pKS.Id = pV.ProjeSahiplikId  ";
            string where = " where pKS.Active = 1 ";
            string groupBy = " group by pKS.Id,pKS.ApproveDate,pKS.InsDate,pKS.EndDate,pKS.ProjeAdi,pKS.StajyerAdi,pKS.ProjeId,pKS.StajyerId,pKS.Active";

            query += select + from + where + groupBy;
            cmd = this.CreateCommand(query);
            AddParameter(cmd, "@Active", true);
            return SelectCompact(cmd).ToList();

            if (kullaniciEntity == null)
            {
                cmd = this.CreateCommand("select distinct pS.Id,pS.ProjeId,p.Adi, max(pV.Versiyon) as [Versiyon] , k.Adi+' '+k.SoyAdi as [Stajyer],k.Id " +
                   "as [StajyerId],pS.Active,pS.EndDate,pS.ApproveDate,pS.InsDate from ProjeSahiplik pS left outer join ProjeVersiyonlari pV on pS.Id = pV.ProjeSahiplikId " +
                   " join Proje p on pS.ProjeId = p.Id join Kullanici k on pS.StajyerId = k.Id" +
                   " where pS.Active = 1 " +

                   " group by pS.ProjeId, p.Adi, k.Adi + ' ' + k.SoyAdi, k.Id,pS.Active,pS.EndDate,pS.ApproveDate, pS.InsDate ,pS.Id order by Versiyon desc");
            }
            else
            {
                cmd = this.CreateCommand("select distinct pS.Id,pS.ProjeId,p.Adi, max(pV.Versiyon) as [Versiyon] , k.Adi+' '+k.SoyAdi as [Stajyer],k.Id " +
                "as [StajyerId],pS.Active,pS.EndDate,pS.ApproveDate,pS.InsDate from ProjeSahiplik pS left outer join ProjeVersiyonlari pV on pS.Id = pV.ProjeSahiplikId " +
                " join Proje p on pS.ProjeId = p.Id join Kullanici k on pS.StajyerId = k.Id" +
                " where pS.Active = 1 and " +
                  "p.Adi like '%'+@ProjeAdi+'%' and k.Adi LIKE '%'+ @KullaniciAdi +'%'" +
                " group by pS.ProjeId, p.Adi, k.Adi + ' ' + k.SoyAdi, k.Id,pS.Active,pS.EndDate,pS.ApproveDate, pS.InsDate ,pS.Id order by Versiyon desc");
                AddParameter(cmd, "@ProjeAdi", projeEntity.Adi);
                AddParameter(cmd, "@Stajyer", kullaniciEntity.Adi);
                AddParameter(cmd, "@KullaniciAdi", kullaniciEntity.Adi);
            }

            return SelectCompact(cmd).ToList();
        }

        public List<ProjeSahiplik> searchInProjeSahiplik(bool beginInsDatePicker, bool beginEndDatePicker, bool beginApproveDatePicker,
            bool finishInsDatePicker, bool finishEndDatePicker, bool finishApproveDatePicker, int selectedState, ProjeSahiplik pSBegin, ProjeSahiplik pSEnd, Proje pEntity,
            Kullanici kEntity)
        {

            IDbCommand cmd = this.CreateCommand("");
            string whereEkle = "";
            string select = "SELECT DISTINCT pS.Id,pS.ProjeId,p.Adi,max(pV.Versiyon) as [Versiyon] , k.Adi + ' ' + k.SoyAdi as [Stajyer],k.Id " +
                   "as [StajyerId],pS.Active,pS.EndDate,pS.ApproveDate,pS.InsDate ";
            string from = " from ProjeSahiplik pS left outer join ProjeVersiyonlari pV on pS.Id = pV.ProjeSahiplikId " +
                   " join Proje p on pS.ProjeId = p.Id join Kullanici k on pS.StajyerId = k.Id";
            string where = " where pS.Active = 1 ";
            string groupBy = " group by pS.ProjeId, p.Adi, k.Adi + ' ' + k.SoyAdi, k.Id,pS.Active,pS.EndDate,pS.ApproveDate, pS.InsDate ,pS.Id order by Versiyon desc";

            whereEkle += checkSelectedDates(beginInsDatePicker, beginEndDatePicker, beginApproveDatePicker,
             finishInsDatePicker, finishEndDatePicker, finishApproveDatePicker, cmd, pSBegin, pSEnd);
            whereEkle += checkSelectedStates(selectedState, cmd, pSBegin, pSEnd);
            whereEkle += getFromTxtField(cmd, pEntity, kEntity);
            where += whereEkle;



            string query = select + from + where + groupBy;
            cmd.CommandText = query;
            return SelectCompact(cmd).ToList();
        }

        private string getFromTxtField(IDbCommand cmd, Proje pEntity, Kullanici kEntity)
        {
            string r = "";
            if (!string.IsNullOrWhiteSpace(pEntity.Adi))
            {
                r += " and p.Adi LIKE '%'+@ProjeAdi+'%'";
                AddParameter(cmd, "@ProjeAdi", pEntity.Adi);
            }
            if (!string.IsNullOrWhiteSpace(kEntity.Adi))
            {
                r += " and k.Adi LIKE '%'+@StajyerAdi+'%'";
                AddParameter(cmd, "@StajyerAdi", kEntity.Adi);
            }
            return r;
        }

        private string checkSelectedStates(int selectedState, IDbCommand cmd, ProjeSahiplik pSBegin, ProjeSahiplik pSEnd)
        {
            string r = "";
            if (selectedState == tumProjeler)
            {
                r += "";
            }
            if (selectedState == teslimEdilmis)
            {
                r += " and pS.ApproveDate is not null ";
            }
            if (selectedState == zamanindaOnce)
            {
                r += " and pS.ApproveDate is not null and Convert(datetime,pS.EndDate,105)>Convert(datetime,pS.ApproveDate,105)";
            }
            if (selectedState == zamaninda)
            {
                r += " and pS.ApproveDate is not null and Convert(datetime,pS.EndDate,105)=Convert(datetime,pS.ApproveDate,105)";
            }
            if (selectedState == zamanindanSonra)
            {
                r += " and pS.ApproveDate is not null and Convert(datetime,pS.EndDate,105)<Convert(datetime,pS.ApproveDate,105)";
            }
            if (selectedState == zamanıDolmusVeTeslimEdilmemis)
            {
                r += " and pS.ApproveDate is null and Convert(datetime,pS.EndDate,105)<Convert(datetime,GETDATE(),105)";
            }
            return r;
        }

        private string checkSelectedDates(bool beginInsDatePicker, bool beginEndDatePicker, bool beginApproveDatePicker
            , bool finishInsDatePicker, bool finishEndDatePicker, bool finishApproveDatePicker, IDbCommand cmd, ProjeSahiplik pSBegin, ProjeSahiplik pSEnd)
        {
            string r = "";
            if (beginInsDatePicker)
            {
                r += " and CONVERT(datetime,pS.InsDate,105)>=@beginInsDate";
                AddParameter(cmd, "@beginInsDate", pSBegin.InsDate);
            }
            if (beginEndDatePicker)
            {
                r += " and CONVERT(datetime,pS.EndDate,105) >=@beginEndDate";
                AddParameter(cmd, "@beginEndDate", pSBegin.EndDate);
            }
            if (beginApproveDatePicker)
            {
                r += " and CONVERT(datetime, pS.ApproveDate,105)>=@beginApproveDate";
                AddParameter(cmd, "@beginApproveDate", pSBegin.ApproveDate);
            }
            if (finishInsDatePicker)
            {
                r += " and CONVERT(datetime, pS.InsDate,105) <=@finishInsDate";
                AddParameter(cmd, "@finishInsDate", pSEnd.InsDate);
            }
            if (finishEndDatePicker)
            {
                r += " and CONVERT(datetime, pS.EndDate,105) <=@finishEndDate";
                AddParameter(cmd, "@finishEndDate", pSEnd.EndDate);
            }
            if (finishApproveDatePicker)
            {
                r += " and CONVERT(datetime,pS.ApproveDate,105) <=@finishApproveDate";
                AddParameter(cmd, "@finishApproveDate", pSEnd.ApproveDate);
            }
            return r;
        }
        public void Delete(ProjeSahiplik Entity)
        {
            Entity.Active = false;
            Save(Entity);
        }

    }
}
