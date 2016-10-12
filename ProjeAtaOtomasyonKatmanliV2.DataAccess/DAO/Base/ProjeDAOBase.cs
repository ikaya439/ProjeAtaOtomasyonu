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
    public class ProjeDAOBase : DAOBase<Proje, int>
    {
        public ProjeDAOBase()
            : base(DbConstants.DatabaseProviderType, DbConstants.DatabaseType, "Proje", DbConstants.ConnectionString)
        {
        }
        public ProjeDAOBase(DbProviderType providerType, Inforce.Lib.DataAccess.DbType databaseType, string tableName, string connectionString)
            : base(providerType, databaseType, tableName, connectionString)
        {
        }

        protected override IDbCommand CreateDeleteOneCommand(int ID)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Proje] WHERE [ID]=@ID");
            CreateIdentityParameter(cmd, ID);
            return cmd;
        }

        protected override void CreateIdentityParameter(IDbCommand cmd, int id)
        {
            AddParameter(cmd, "@Id", id);
        }

        protected override IDbCommand CreateInsertCommand(Proje o)
        {
            Proje entity = o;
            IDbCommand cmd = this.CreateCommand("INSERT INTO [dbo].[Proje] ([Adi],[Konu],[Tanitim]" +
                ",[Active],[InsDate]) VALUES(@Adi,@Konu,@Tanitim,@Active,@InsDate)");
            CreateValueParameters(cmd, o);
            return cmd;
        }

        protected override IDbCommand CreateSelectOneCommand(int ID)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Proje] WHERE [ID]=@ID");
            CreateIdentityParameter(cmd, ID);
            return cmd;
        }

        protected override IDbCommand CreateUpdateCommand(Proje o)
        {
            Proje entity = o;
            IDbCommand cmd = this.CreateCommand("UPDATE [dbo].[Proje] SET[Adi] = @Adi,[Konu] =@Konu ,[Tanitim] =@Tanitim" +
                ",[Active] =@Active ,[InsDate] =@InsDate where [Id]=@Id");
            CreateValueParameters(cmd, o);
            CreateIdentityParameter(cmd, o.Id);
            return cmd;
        }

        protected override void CreateValueParameters(IDbCommand cmd, Proje o)
        {
            AddParameter(cmd, "@Adi", o.Adi);
            AddParameter(cmd, "@Konu", o.Konu);
            AddParameter(cmd, "@Tanitim", o.Tanitim);
            AddParameter(cmd, "@Active", o.Active);
            AddParameter(cmd, "@InsDate", o.InsDate);
        }

        protected override bool IsSaved(Proje o)
        {
            return o.Id > 0;
        }

        protected override Proje MapObject(IDataReader dr)
        {
            Proje entity = new Proje();
            entity.Id = (int)MapValue(dr, "Id");
            entity.Adi = (string)MapValue(dr, "Adi");
            entity.Konu = (string)MapValue(dr, "Konu");
            entity.Tanitim = (string)MapValue(dr, "Tanitim");
            entity.Active = (bool)MapValue(dr, "Active");
            entity.InsDate = (DateTime)MapValue(dr, "InsDate");
            return entity;
        }
    }
}
