using ProjeAtaOtomasyonKatmanliV2.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess.DAO
{
    public class ProjeDAO : Base.ProjeDAOBase
    {
        public ProjeDAO() : base()
        {

        }
        public List<Proje> SearchInProjects(Proje Entity)
        {
            IDbCommand cmd = this.CreateCommand("SELECT * FROM [Proje] WHERE Active = 1 and [Adi] like '%'+@Adi+'%' and [Konu] like '%'+@Konu+'%'" +
               " and [Tanitim] like '%'+@Tanitim+'%'");
            AddParameter(cmd, "@Adi", Entity.Adi);
            AddParameter(cmd, "@Konu", Entity.Konu);
            AddParameter(cmd, "@Tanitim", Entity.Tanitim);
            return Select(cmd).ToList<Proje>();
        }
        public bool existingControl(Proje Entity)
        {
            IDbCommand cmd;
            if (Entity.Id != 0)
            {
                cmd = this.CreateCommand("SELECT * FROM [Proje] WHERE [Active] = @Active and [Adi] = @Adi and" +
                    " convert(nvarchar(max), [Konu]) = @Konu and convert(nvarchar(max), [Tanitim]) = @Tanitim and [Id] != @Id");
                CreateIdentityParameter(cmd, Entity.Id);
            }
            else
            {
                cmd = this.CreateCommand("SELECT * FROM [Proje] WHERE [Active] = @Active and [Adi] = @Adi and convert(nvarchar(max), [Konu]) = @Konu and convert(nvarchar(max), [Tanitim]) = @Tanitim");
            }
            AddParameter(cmd, "@Active", true);
            AddParameter(cmd, "@Adi", Entity.Adi);
            AddParameter(cmd, "@Konu", Entity.Konu);
            AddParameter(cmd, "@Tanitim", Entity.Tanitim);

            Proje pAra = SelectOne(cmd);
            if (pAra != null)
                return true;

            return false;
        }
    }
}
