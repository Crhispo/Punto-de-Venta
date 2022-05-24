using System.Collections.Generic;
using System.Data;
namespace Datos
{
    public class GestionSqlClient
    {
        readonly ConexionSql conexionSql = new ConexionSql();
        int flag = 0;
        public int InsertarCliente(string nombre, string apellidos, string telefono, string correo, string codigocliente, string descuento, string cantcompras)
        {
            string Query = $"Insert into Tbl_Cliente (nombrecliente, apellidocliente, telefonocliente, correocliente, codigocliente, descuento, cantcompras) values ('{nombre}', '{apellidos}', {telefono}, '{correo}', '{codigocliente}', {descuento},{cantcompras})";
            flag = conexionSql.QuerySql(Query, 1);
            return flag;
        }
        public int ModificarCliente(string id, string nombre, string apellidos, string telefono, string correo, string codigocliente, string descuento, string cantcompras)
        {
            string Query = $"Update Tbl_Cliente set nombrecliente = '{nombre}', apellidocliente = '{apellidos}', telefonocliente = {telefono}, correocliente = '{correo}', codigocliente = '{codigocliente}', descuento = {descuento}, cantcompras = {cantcompras}  where id = {id}";
            flag = conexionSql.QuerySql(Query, 1);
            return flag;
        }
        public int EliminarCliente(string id)
        {
            string Query = $"delete from Tbl_Cliente where id = {id}";
            flag = conexionSql.QuerySql(Query, 1);
            return flag;
        }
        public List<string> ConsultarCliente(string codigoCliente)
        {
            string Query = $"SELECT nombrecliente + ' ' + apellidocliente as nombrecompletocliente, descuento FROM Tbl_Cliente where codigocliente = '{codigoCliente}'";
            List<string> resp = conexionSql.ConsultarDatosSql(Query);
            return resp;
        }
        public DataTable ConsultarClientes()
        {
            string Query = "select * from Tbl_Cliente";
            DataTable table = conexionSql.Consultartable(Query);
            return table;
        }
    }
}
