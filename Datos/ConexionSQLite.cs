using System;
using System.Data;
using System.Data.SQLite;

namespace Datos
{
    public class ConexionSQLite
    {
        static readonly string connectionString = @"Data Source=.\Puntodeventa.sqlite;";
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

        public int InsertarUsuario(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            int flag = 0;
            SQLite.Open();
            string query = $"Insert into Tbl_Persona (nombre,apellidos,dni,telefono,usuario,clave) values ('{nombre}','{apellidos}',{dni},{telefono},'{usuario}','{clave}')";
            SQLiteCommand cmd = new SQLiteCommand(query, SQLite);
            flag = cmd.ExecuteNonQuery();
            SQLite.Close();
            return flag;
        }

        public int ModificarUsuario(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            int flag = 0;
            string StringUserId;
            SQLite.Open();
            string queryid = $"Select * from Tbl_Persona where dni = {dni}";
            SQLiteCommand cmdid = new SQLiteCommand(queryid, SQLite);
            SQLiteDataReader Usuario = cmdid.ExecuteReader();
            if (Usuario.Read())
            {
                StringUserId = Usuario["id"].ToString();
                string query = $"Update Tbl_Persona set nombre = '{nombre}', apellidos = '{apellidos}', dni = {dni}, telefono = {telefono}, usuario = '{usuario}', clave = '{clave}' where id = {StringUserId}";
                SQLiteCommand cmd = new SQLiteCommand(query, SQLite);
                flag = cmd.ExecuteNonQuery();
                SQLite.Close();
                return flag;
            }
            else
            {
                SQLite.Close();
                return flag;
            }



        }

        public int EliminarUsuario(string dni)
        {
            int flag = 0;
            string StringUserId;
            SQLite.Open();
            string queryid = $"Select * from Tbl_Persona where dni = {dni}";
            SQLiteCommand cmdid = new SQLiteCommand(queryid, SQLite);
            SQLiteDataReader Usuario = cmdid.ExecuteReader();
            if (Usuario.Read())
            {
                StringUserId = Usuario["id"].ToString();
                string query = $"delete from Tbl_Persona where id = {StringUserId}";
                SQLiteCommand cmd = new SQLiteCommand(query, SQLite);
                flag = cmd.ExecuteNonQuery();
                SQLite.Close();
                return flag;
            }
            else
            {
                SQLite.Close();
                return flag;
            }



        }

        public DataTable ConsultarUsuarios()
        {
            string query = "select * from Tbl_Persona";
            SQLiteCommand cmd = new SQLiteCommand(query, SQLite);
            SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;

        }
    }
}
