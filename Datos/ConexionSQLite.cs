using System;
using System.Data;
using System.Data.SQLite;
namespace Datos
{
    public class ConexionSQLite
    {
        int flag = 0;
        static readonly string connectionString = @"Data Source=.\Puntodeventa.sqlite;";
        readonly SQLiteConnection SQLite = new SQLiteConnection(connectionString);
        public int QuerySQLite(string Query, int TipoQuery)
        {
            int resp;
            SQLite.Open();
            SQLiteCommand cmd = new SQLiteCommand(Query, SQLite);
            /*
            Codigo numerico tipo de Query
            Consulta Login = 0
            Modificar datos de tabla = 1
            Consultar id = 2
            Consuta tabla adapter = 3
            */
            switch (TipoQuery)
            {
                case 0:
                    int count;
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                    resp = count;
                    break;
                case 1:
                    flag = cmd.ExecuteNonQuery();
                    resp = flag;
                    break;
                default:
                    resp = flag;
                    break;
            };
            SQLite.Close();
            return resp;
        }
        public DataTable ConsultarUsers(string Query)
        {
            SQLite.Open();
            SQLiteCommand cmd = new SQLiteCommand(Query, SQLite);
            SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            SQLite.Close();
            return table;
        }
    }
}