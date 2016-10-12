using Inforce.Lib.DataAccess;
using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO.Base
{
  public  class ProjeVersiyonlariDAOBase : CompactDAOBase<ProjeVersiyonlari, int>
    {
        public ProjeVersiyonlariDAOBase()
            : base(DbConstants.DatabaseProviderType, DbConstants.DatabaseType, "ProjeVersiyonlari", DbConstants.ConnectionString)
        {
        }
        public ProjeVersiyonlariDAOBase(DbProviderType providerType, Inforce.Lib.DataAccess.DbType databaseType, string tableName, string connectionString)
            : base(providerType, databaseType, tableName, connectionString)
        {
        }

        protected override IDbCommand CreateDeleteOneCommand(int ID)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [ProjeVersiyonlari] WHERE [ID]=@ID");
            CreateIdentityParameter(cmd, ID);
            return cmd;
        }

        protected override void CreateIdentityParameter(IDbCommand cmd, int ID)
        {
            AddParameter(cmd, "@Id", ID);
        }

        protected override IDbCommand CreateInsertCommand(ProjeVersiyonlari o)
        {
            ProjeVersiyonlari entity = o;
            IDbCommand cmd = this.CreateCommand("INSERT INTO [dbo].[ProjeVersiyonlari] ([Path] ,[Versiyon] ,[ProjeSahiplikId] ,[Active]" +
                ",[InsDate])VALUES (@Path,@Versiyon ,@ProjeSahiplikId ,@Active ,@InsDate)");
            CreateValueParameters(cmd, o);
            return cmd;
        }

        protected override IDbCommand CreateSelectOneCommand(int ID)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [ProjeVersiyonlari] WHERE [ID]=@ID");
            CreateIdentityParameter(cmd, ID);
            return cmd;
        }

        protected override IDbCommand CreateUpdateCommand(ProjeVersiyonlari o)
        {
            ProjeVersiyonlari entity = o;
            IDbCommand cmd = this.CreateCommand("UPDATE [dbo].[ProjeVersiyonlari] SET [Path] =@Path,"+
                "[Versiyon] =@Versiyon,[ProjeSahiplikId] = @ProjeSahiplikId" +
                                                 ",[Active] = @Active,[InsDate] = @InsDate WHERE [Id]=@Id");
            CreateValueParameters(cmd, o);
            CreateIdentityParameter(cmd, o.Id);
            return cmd;
        }

        protected override void CreateValueParameters(IDbCommand cmd, ProjeVersiyonlari o)
        {
            AddParameter(cmd, "@Path", o.Path);
            AddParameter(cmd, "@Versiyon", o.Versiyon);
            AddParameter(cmd, "@ProjeSahiplikId", o.ProjeSahiplikId);
            AddParameter(cmd, "@Active", o.Active);
            AddParameter(cmd, "@InsDate", o.InsDate);
        }

        protected override bool IsSaved(ProjeVersiyonlari o)
        {
            return o.Id > 0;
        }

        protected override ProjeVersiyonlari MapObject(IDataReader dr)
        {
            ProjeVersiyonlari entity = new ProjeVersiyonlari();
            entity.Id = (int)MapValue(dr, "Id");
            entity.Path = (string)MapValue(dr, "Path");
            entity.Versiyon = (string)MapValue(dr, "Versiyon");
            entity.ProjeSahiplikId = (int)MapValue(dr, "ProjeSahiplikId");
            entity.Active = (bool)MapValue(dr, "Active");
            entity.InsDate = (DateTime)MapValue(dr, "InsDate");
            return entity;
        }

        protected override ProjeVersiyonlari MapObjectCompact(IDataReader dr)
        {
            ProjeVersiyonlari entity = new ProjeVersiyonlari();
            entity.Id = (int)MapValue(dr, "Id");
            entity.ProjeAdi = (string)MapValue(dr, "Adi");
            entity.ProjeSahiplikId = (int)MapValue(dr, "ProjeSahiplikId");
            entity.Versiyon = (string)MapValue(dr, "Versiyon");
            entity.Active = (bool)MapValue(dr, "Active");
            entity.InsDate = (DateTime)MapValue(dr, "InsDate");
            return entity;
        }
    }
}
