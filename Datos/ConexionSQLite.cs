using System;
using System.Data.SQLite;

namespace Datos
{
    public class ConexionSQLite
    {
        static readonly string connectionString = @"Data Source=C:\Users\Crhispo\source\repos\VentaForm\Datos\Puntodeventa.sqlite;";
        readonly SQLiteConnection SQLite = new SQLiteConnection(connectionString);
        public int ConsultaLogin(string Usuario, string Clave)
        {
            int count;
            SQLite.Open();
            string Query = "Select Count(*) From Tbl_Persona where usuario ='" + Usuario + "'" +
                "and Clave ='" + Clave + "'";
            SQLiteCommand cmd = new SQLiteCommand(Query, SQLite);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            SQLite.Close();

            return count;
        }
    }
}
