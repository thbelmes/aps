using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceAndPayrollSystem.Database
{
    public class Db<TType>
            where TType : IConvertible
    {
        public string ConnectionString
        {
            get
            {
                // pattern: Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;Initial Catalog = myDataBase; User ID = myUsername; Password = myPassword;
                var server = ConfigurationManager.AppSettings["db.server"];
                var dbName = ConfigurationManager.AppSettings["db.name"];
                var username = ConfigurationManager.AppSettings["db.username"];
                var pwd = ConfigurationManager.AppSettings["db.pwd"];

                var connStr = $"Data Source={server};Initial Catalog={dbName};User ID={username};Password={pwd};MultipleActiveResultSets=true";

                return connStr;
            }
        }

        public string SelectScopeIdentitySql()
        {
            if (typeof(TType) == typeof(int))
                return "SELECT CAST(SCOPE_IDENTITY() AS INT) AS LAST_IDENTITY";
            if (typeof(TType) == typeof(long))
                return "SELECT CAST(SCOPE_IDENTITY() AS BIGINT) AS LAST_IDENTITY";
            if (typeof(TType) == typeof(short))
                return "SELECT CAST(SCOPE_IDENTITY() AS SMALLINT) AS LAST_IDENTITY";

            return "SELECT SCOPE_IDENTITY()";

        }
    }
}
