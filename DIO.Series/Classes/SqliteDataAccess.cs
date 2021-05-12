using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace DIO.Series
{
    class SqliteDataAccess
    {
        public static List<User> LoadUsers()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<User>("select * from Usuarios", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(User pUser)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute("insert into Usuarios (Nome, Username, Senha, Salt) values (@Nome, @Username, @Senha, @Salt)", pUser);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
