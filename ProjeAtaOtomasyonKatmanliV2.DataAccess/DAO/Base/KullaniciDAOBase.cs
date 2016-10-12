using Inforce.Lib.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO.Base
{
    public class KullaniciDAOBase : CompactDAOBase<Kullanici, int>
    {
        public KullaniciDAOBase()
            : base(DbConstants.DatabaseProviderType, DbConstants.DatabaseType, "Kullanici", DbConstants.ConnectionString)
        {
        }
        public KullaniciDAOBase(DbProviderType providerType, Inforce.Lib.DataAccess.DbType databaseType, string tableName, string connectionString)
            : base(providerType, databaseType, tableName, connectionString)
        {
        }

        protected override IDbCommand CreateDeleteOneCommand(int ID)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Kullanici] WHERE [ID]=@ID");
            CreateIdentityParameter(cmd, ID);
            return cmd;
        }

        protected override void CreateIdentityParameter(IDbCommand cmd, int ID)
        {
            AddParameter(cmd, "@Id", ID);
        }

        protected override IDbCommand CreateInsertCommand(Kullanici o)
        {
            Kullanici entity = o;
            IDbCommand cmd = this.CreateCommand("INSERT INTO [dbo].[Kullanici] ([Adi],[SoyAdi],[Email]"+
                ",[Sifre],[Tel],[AdminStajyer],[Active],[InsDate])VALUES (@Adi,@SoyAdi,@Email,@Tel,@Sifre"+
                ",@AdminStajyer,@Active,@InsDate)");
            CreateValueParameters(cmd, o);
            return cmd;
        }

        protected override IDbCommand CreateSelectOneCommand(int ID)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Kullanici] WHERE [ID]=@ID");
            CreateIdentityParameter(cmd, ID);
            return cmd;
        }

        protected override IDbCommand CreateUpdateCommand(Kullanici o)
        {
            Kullanici entity = o;
            IDbCommand cmd = this.CreateCommand("UPDATE [dbo].[Kullanici] SET [Adi]=@Adi,[SoyAdi]=@SoyAdi,[Email]=@Email,[Sifre]=@Sifre,[Tel]=@Tel" +
                ",[AdminStajyer]=@AdminStajyer,[Active]=@Active,[InsDate]=@InsDate where [Id]=@Id");
            CreateValueParameters(cmd, o);
            CreateIdentityParameter(cmd, o.Id);
            return cmd;
        }

        protected override void CreateValueParameters(IDbCommand cmd, Kullanici o)
        {
            AddParameter(cmd, "@Adi", o.Adi);
            AddParameter(cmd, "@SoyAdi", o.SoyAdi);
            AddParameter(cmd, "@Email", o.Email);
            AddParameter(cmd, "@Tel", o.Tel);
            AddParameter(cmd, "@Sifre", o.Sifre);
            AddParameter(cmd, "@AdminStajyer", o.AdminStajyer);
            AddParameter(cmd, "@Active", o.Active);
            AddParameter(cmd, "@InsDate", o.InsDate);
        }

        protected override bool IsSaved(Kullanici o)
        {
            return o.Id > 0;
        }

        protected override Kullanici MapObject(IDataReader dr)
        {
            Kullanici entity = new Kullanici();
            entity.Id = (int)MapValue(dr, "Id");
            entity.Adi = (string)MapValue(dr, "Adi");
            entity.SoyAdi = (string)MapValue(dr, "SoyAdi");
            entity.Email = (string)MapValue(dr, "Email");
            entity.Tel = (string)MapValue(dr, "Tel");
            entity.Sifre = (string)MapValue(dr, "Sifre");
            entity.AdminStajyer = (bool)MapValue(dr, "AdminStajyer");
            entity.Active = (bool)MapValue(dr, "Active");
            entity.InsDate = (DateTime)MapValue(dr, "InsDate");
            return entity;
        }

        protected override Kullanici MapObjectCompact(IDataReader dr)
        {
            Kullanici entity = new Kullanici();
            entity.Id = (int)MapValue(dr, "Id");
            entity.ProjeId = MapValue(dr, "ProjeId") == null ? 0 : (int)MapValue(dr, "ProjeId");
            entity.Adi = (string)MapValue(dr, "Adi");
            entity.SoyAdi = (string)MapValue(dr, "SoyAdi");
            entity.Email = (string)MapValue(dr, "Email");
            entity.Tel = (string)MapValue(dr, "Tel");
            entity.Sifre = (string)MapValue(dr, "Sifre");
            entity.AdminStajyer = (bool)MapValue(dr, "AdminStajyer");
            entity.Active = (bool)MapValue(dr, "Active");
            entity.InsDate = (DateTime)MapValue(dr, "InsDate");
            return entity;
        }
    }
}
