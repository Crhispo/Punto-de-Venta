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
        public DataTable Consultartable(string Query)
        {
            SQLite.Open();
            SQLiteCommand cmd = new SQLiteCommand(Query, SQLite);
            SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            SQLite.Close();
            return table;
        }

        public string ConsultarDatosSQLite(string Query)
        {
            SQLite.Open();
            string resp;
            SQLiteCommand cmd = new SQLiteCommand(Query, SQLite);
            SQLiteDataReader reg = cmd.ExecuteReader();
            if (reg.Read()) { resp = reg["numfact"].ToString(); }
            else { resp = "Null"; }
            SQLite.Close();
            return resp;
        }
    }
}