using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class ConexionSql
    {
        static readonly string connectionString = @"server=DESKTOP-DIP02I4\SQLSERVER; database=Punto-de-venta; integrated security=true;";
        readonly SqlConnection Sql = new SqlConnection(connectionString);
        public int QuerySql(string Query, int TipoQuery)
        {
            int flag;
            int resp = 0;
            Sql.Open();
            SqlCommand cmd = new SqlCommand(Query, Sql);
            /*
            Codigo numerico tipo de Query
            Consulta Login = 0
            Modificar datos de tabla = 1
            */
            switch (TipoQuery)
            {
                case 0:
                    flag = Convert.ToInt32(cmd.ExecuteScalar());
                    resp = flag;
                    break;
                case 1:
                    flag = cmd.ExecuteNonQuery();
                    resp = flag;
                    break;
            };
            Sql.Close();
            return resp;
        }
        public DataTable Consultartable(string Query)
        {
            Sql.Open();
            SqlCommand cmd = new SqlCommand(Query, Sql);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            Sql.Close();
            return table;
        }
        public List<string> ConsultarDatosSql(string Query)
        {
            Sql.Open();
            List<string> resp = new List<string>();
            SqlCommand cmd = new SqlCommand(Query, Sql);
            SqlDataReader reg = cmd.ExecuteReader();
            if (reg.Read())
            {
                for (int key = 0; key < reg.FieldCount; key++)
                { resp.Add(reg.GetValue(key).ToString()); }
            }
            else
            {
                for (int key = 0; key < reg.FieldCount; key++)
                { resp.Add("Null"); }
            }
            Sql.Close();
            return resp;
        }

    }
}