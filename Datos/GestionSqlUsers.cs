using System.Data;
namespace Datos
{
    public class GestionSqlUsers
    {
        readonly ConexionSql conexionSql = new ConexionSql();
        private int flag;
        /*
        Codigo numerico tipo de Query
        Consulta Login = 0
        Modificar datos de tabla = 1
        */
        public int ConsultaLogin(string Usuario, string Clave)
        {
            string Query = $"Select Count(*) From Tbl_Persona where usuario = '{Usuario}' and Clave = '{Clave}'";
            int count = conexionSql.QuerySql(Query, 0);
            return count;
        }
        public int InsertarUsuario(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            string Query = $"Insert into Tbl_Persona (nombre, apellidos, dni, telefono, usuario, clave) values ('{nombre}', '{apellidos}', {dni}, {telefono}, '{usuario}', '{clave}')";
            flag = conexionSql.QuerySql(Query, 1);
            return flag;
        }
        public int ModificarUsuario(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            string Query = $"Update Tbl_Persona set nombre = '{nombre}', apellidos = '{apellidos}', dni = {dni}, telefono = {telefono}, usuario = '{usuario}', clave = '{clave}' where dni = {dni}";
            flag = conexionSql.QuerySql(Query, 1);
            return flag;
        }
        public int EliminarUsuario(string dni)
        {
            string Query = $"delete from Tbl_Persona where dni = {dni}";
            flag = conexionSql.QuerySql(Query, 1);
            return flag;
        }
        public DataTable ConsultarUsuarios()
        {
            string Query = "select * from Tbl_Persona";
            DataTable table = conexionSql.Consultartable(Query);
            return table;
        }
    }
}