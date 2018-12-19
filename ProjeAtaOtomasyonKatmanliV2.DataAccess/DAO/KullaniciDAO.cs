using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO
{
    public class KullaniciDAO : Base.KullaniciDAOBase
    {
        public KullaniciDAO()
            : base()
        {
        }
        public Kullanici SelectOneUserByEmailAndPhone(Kullanici entity)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Kullanici] WHERE Active = 1 and ([Email]= @Email or [Tel]=@Tel)");
            AddParameter(cmd, "@Email", entity.Email);
            AddParameter(cmd, "@Tel", entity.Tel);
            return SelectOne(cmd);
        }

        public Kullanici SelectOneUserByEmailAndPassword(Kullanici entity)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Kullanici] WHERE Active = 1 and ([Email]= @Email and [Sifre]=@Sifre)");
            AddParameter(cmd, "@Email", entity.Email);
            AddParameter(cmd, "@Sifre", entity.Sifre);
            return SelectOne(cmd);
        }

        public List<Kullanici> SelectAllUserByCalisanStajyerState(bool calisanStajyer)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Kullanici] WHERE [AdminStajyer] = @AdminStajyer and [Active] = @Active");
            AddParameter(cmd, "@AdminStajyer", calisanStajyer);
            AddParameter(cmd, "@Active", true);
            return (List<Kullanici>)Select(cmd);
        }
        public List<Kullanici> SearchInUsers(Kullanici entity)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Kullanici] WHERE [Email] like " +
                "'%'+@Email+'%' and [Tel] like '%'+@Tel+'%'" +
                " and [Adi] like '%'+@Adi+'%' and [SoyAdi] like " +
                "'%'+@SoyAdi+'%' and [Active]=@Active and [AdminStajyer]=@AdminStajyer");
            AddParameter(cmd, "@Adi", entity.Adi);
            AddParameter(cmd, "@SoyAdi", entity.SoyAdi);
            AddParameter(cmd, "@Email", entity.Email);
            AddParameter(cmd, "@Tel", entity.Tel);
            AddParameter(cmd, "@Active", true);
            AddParameter(cmd, "@AdminStajyer", entity.AdminStajyer);

            return (List<Kullanici>)Select(cmd);
        }
        public void Delete(Kullanici entity)
        {
            entity.Active = false;
            Save(entity);
        }

        public bool existingControl(Kullanici Entity)
        {
            IDbCommand cmd;
            if (Entity.Id != 0)
            {
                cmd = this.CreateCommand("SELECT * FROM [Kullanici] WHERE [Active]=@Active and ([Email]=@Email or [Tel]=@Tel) and [Id]!=@Id");
                CreateIdentityParameter(cmd, Entity.Id);
            }
            else
            {
                cmd = this.CreateCommand("SELECT * FROM [Kullanici] WHERE [Active] = @Active and ([Email] = @Email or [Tel]=@Tel)");
            }
            AddParameter(cmd, "@Active", true);
            AddParameter(cmd, "@Email", Entity.Email);
            AddParameter(cmd, "@Tel", Entity.Tel);
   
            Kullanici pAra = SelectOne(cmd);
            if (pAra != null)
                return true;

            return false;
        }
        public List<Kullanici> getAllInternWithoutAssignmentForSelectedProject(Proje projeEntity)
        {
            IDbCommand cmd = this.CreateCommand("select k.*,kPS.ProjeId from " +
                "( select k.Id,pS.ProjeId from Kullanici k left join ProjeSahiplik pS " +
                "on k.Id = pS.StajyerId where pS.ProjeId  = @ProjeId ) as kPS right join " +
                "Kullanici k on kPS.Id = k.Id where  (kPS.Id is null or k.Id is null)" +
                "and k.AdminStajyer=0 and k.Active=1");
            AddParameter(cmd, "@ProjeId", projeEntity.Id);
            return SelectCompact(cmd).ToList();
        }
        public List<Kullanici> SerarchInInternWithoutAssignmentForSelectedProject(Proje projeEntity, Kullanici kullaniciEntity)
        {
            IDbCommand cmd = this.CreateCommand("select k.*,kPS.ProjeId from ( select k.Id,pS.ProjeId from Kullanici k left join ProjeSahiplik pS " +
                "on k.Id = pS.StajyerId where pS.ProjeId  = @ProjeId ) as kPS right join Kullanici k on kPS.Id = k.Id where  (kPS.Id is null or k.Id is null)" +
                "and k.AdminStajyer=0 and k.Active=1 and  k.Adi LIKE '%'+@Adi+'%' and k.SoyAdi LIKE '%'+@SoyAdi+'%' " +
                "and k.Email LIKE '%'+@Email+'%' and k.Tel LIKE '%'+@Tel+'%'");
            AddParameter(cmd, "@ProjeId", projeEntity.Id);
            AddParameter(cmd, "@Adi", kullaniciEntity.Adi);
            AddParameter(cmd, "@SoyAdi", kullaniciEntity.SoyAdi);
            AddParameter(cmd, "@Email", kullaniciEntity.Email);
            AddParameter(cmd, "@Tel", kullaniciEntity.Tel);
            return SelectCompact(cmd).ToList();
        }
    }
}
