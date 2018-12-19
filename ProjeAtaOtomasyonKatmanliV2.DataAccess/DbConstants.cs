using System;
using System.Collections.Generic;
using System.Text;
using Inforce.Lib.DataAccess;

namespace ProjeAtaOtomasyonKatmanliV2.DataAccess
{
    public class DbConstants
    {
        public static readonly DbProviderType DatabaseProviderType = DbProviderType.SQLSERVER;
        public static readonly DbType DatabaseType = DbType.SQLSERVER;

        public static readonly string ConnectionString = @"Data Source=DESKTOP-AD56DF7\SQLEXPRESS;Initial Catalog=ProjeAtamaOtomasyonu;Integrated Security=True;Connect " +
        "Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static System.Data.IDbConnection Connection;
    }
}
