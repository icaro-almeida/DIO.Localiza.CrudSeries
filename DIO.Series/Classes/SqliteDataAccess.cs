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
    public class SqliteDataAccess
    {
        public static List<User> LoadUsers()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<User>("select * from Usuarios", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Serie> LoadSeries()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<Serie>("select * from Series", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Filme> LoadFilmes()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<Filme>("select * from Filmes", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void UpdateSerie(Serie pSerie)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute("update Series set" +
                    " Genero = @Genero," +
                    " Titulo = @Titulo," +
                    " Ano = @Ano," +
                    " Descricao = @Descricao, " +
                    " Excluido = @Excluido" +
                    " where Id = @Id", pSerie);
            }
        }

        public static void UpdateFilme(Filme pFilme)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute("update Filmes set" +
                    " Genero = @Genero," +
                    " Titulo = @Titulo," +
                    " Ano = @Ano," +
                    " Descricao = @Descricao, " +
                    " Excluido = @Excluido" +
                    " where Id = @Id", pFilme);
            }
        }

        public static void SaveUser(User pUser)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute("insert into Usuarios (Nome, Username, Senha, Salt) " +
                    "values (@Nome, @Username, @Senha, @Salt)", pUser);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
