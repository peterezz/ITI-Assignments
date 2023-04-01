using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Ado.NetDay09
{
    class DatabaseHelper
    {
        public static SqlConnection sqlConnection { get; } = new SqlConnection();
        static DatabaseHelper()
        {
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings[ "NorthWind" ].ConnectionString;
        }

    }
}
