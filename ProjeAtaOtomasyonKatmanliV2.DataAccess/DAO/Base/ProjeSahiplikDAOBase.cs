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
    public class ProjeSahiplikDAOBase : CompactDAOBase<ProjeSahiplik, int>
    {
            
        public ProjeSahiplikDAOBase()
            : base(DbConstants.DatabaseProviderType, DbConstants.DatabaseType, "ProjeSahiplik", DbConstants.ConnectionString)
        {
        }
        public ProjeSahiplikDAOBase(DbProviderType providerType, Inforce.Lib.DataAccess.DbType databaseType, string tableName, string connectionString)
            : base(providerType, databaseType, tableName, connectionString)
        {
        }
        protected override IDbCommand CreateDeleteOneCommand(int ID)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [ProjeSahiplik] WHERE [ID]=@ID");
            CreateIdentityParameter(cmd, ID);
            return cmd;
        }

        protected override void CreateIdentityParameter(IDbCommand cmd, int ID)
        {
            AddParameter(cmd, "@Id", ID);
        }

        protected override IDbCommand CreateInsertCommand(ProjeSahiplik o)
        {
            ProjeSahiplik entity = o;
            IDbCommand cmd = this.CreateCommand("INSERT INTO [dbo].[ProjeSahiplik]([ProjeId],[StajyerId],[EndDate]" +
                ",[Active],[InsDate]) VALUES(@ProjeId,@StajyerId, @EndDate,@Active,@InsDate)");
            CreateValueParameters(cmd, o);
            return cmd;
        }

        protected override IDbCommand CreateSelectOneCommand(int ID)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [ProjeSahiplik] "+
                "WHERE [ID]=@ID");
            CreateIdentityParameter(cmd, ID);
            return cmd;
        }

        protected override IDbCommand CreateUpdateCommand(ProjeSahiplik o)
        {
            ProjeSahiplik entity = o;
            string set = "";
           string update = " UPDATE [dbo].[ProjeSahiplik] ";

            if (o.ApproveDate != Convert.ToDateTime("1.01.0001 00:00:00"))
            {
                set = " SET Path = @Path , ProjeId = @ProjeId , StajyerId = @StajyerId, ApproveDate  =  @ApproveDate, EndDate = @EndDate , Active = @Active , InsDate = @InsDate ";
            }
            else
            {
                set = " SET Path = @Path , ProjeId = @ProjeId , StajyerId = @StajyerId, EndDate = @EndDate , Active = @Active , InsDate = @InsDate ";
            }

             
            string where = " WHERE [Id] = @Id ";
            string query = update + set + where;

            IDbCommand cmd = this.CreateCommand(query);
            CreateValueParameters(cmd, o);
            CreateIdentityParameter(cmd, o.Id);
            return cmd;
        }

        protected override void CreateValueParameters(IDbCommand cmd, ProjeSahiplik o)
        {
            AddParameter(cmd, "@ProjeId", o.ProjeId);
            AddParameter(cmd, "@StajyerId", o.StajyerId);
            AddParameter(cmd, "@Path", o.Path);
            AddParameter(cmd, "@Active", o.Active);
            AddParameter(cmd, "@EndDate", o.EndDate);
            if(o.ApproveDate!= Convert.ToDateTime("1.01.0001 00:00:00"))
            AddParameter(cmd, "@ApproveDate", o.ApproveDate);
            AddParameter(cmd, "@InsDate", o.InsDate);
        }

        protected override bool IsSaved(ProjeSahiplik o)
        {
            return o.Id > 0;
        }

        protected override ProjeSahiplik MapObject(IDataReader dr)
        {
            ProjeSahiplik entity = new ProjeSahiplik();
            entity.Id = (int)MapValue(dr, "Id");
            entity.Path = (string)MapValue(dr, "Path");
            entity.ProjeId = (int)MapValue(dr, "ProjeId");
            entity.StajyerId = (int)MapValue(dr, "StajyerId");
            entity.Active = (bool)MapValue(dr, "Active");
            entity.EndDate = (DateTime)MapValue(dr, "EndDate");
            entity.ApproveDate = Convert.ToDateTime(MapValue(dr, "ApproveDate"));
            entity.InsDate = (DateTime)MapValue(dr, "InsDate");
            return entity;
        }

        protected override ProjeSahiplik MapObjectCompact(IDataReader dr)
        {
            ProjeSahiplik entity = new ProjeSahiplik();
            entity.Id = (int)MapValue(dr, "Id");
            entity.Adi = (string)MapValue(dr, "Adi");
            entity.Versiyon = (MapValue(dr, "Versiyon") == null ? "<yok>" : (string)MapValue(dr, "Versiyon"));
            entity.StajyerId = (int)MapValue(dr, "StajyerId");
            entity.Stajyer = (string)MapValue(dr, "Stajyer");
            entity.ProjeId = (int)MapValue(dr, "ProjeId");
            entity.Active = (bool)MapValue(dr, "Active");
            entity.EndDate = (DateTime)MapValue(dr, "EndDate");
            entity.ApproveDate = Convert.ToDateTime(MapValue(dr, "ApproveDate"));
            entity.InsDate = (DateTime)MapValue(dr, "InsDate");
            return entity;
        }
    }
}
