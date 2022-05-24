using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class GestionSqlInventory
    {
        readonly ConexionSql conexionSQLite = new ConexionSql();
        private int flag;
        /*
        Codigo numerico tipo de Query
        Consulta Login = 0
        Modificar datos de tabla = 1
        */
        public int InsertarProducto(string producto, string categoria, string precio, string cantidad, string codigo)
        {
            string Query = $"Insert into Tbl_Inventario (producto, categoria, precio, cantidad, codigo) values ('{producto}', '{categoria}', {precio}, {cantidad},'{codigo}')";
            flag = conexionSQLite.QuerySql(Query, 1);
            return flag;
        }
        public int ModificarProducto(string id, string producto, string categoria, string precio, string cantidad, string codigo)
        {
            string Query = $"Update Tbl_Inventario set producto = '{producto}', categoria = '{categoria}', precio = {precio}, telefono = {cantidad},codigo = '{codigo}' where id = {id}";
            flag = conexionSQLite.QuerySql(Query, 1);
            return flag;
        }
        public int EliminarProducto(string id)
        {
            string Query = $"delete from Tbl_Inventario where id = {id}";
            flag = conexionSQLite.QuerySql(Query, 1);
            return flag;
        }
        public List<string> ConsultaInventario(string codigo)
        {
            string Query = $"SELECT producto, Precio FROM Tbl_Inventario where Codigo = '{codigo}'";
            List<string> resp = conexionSQLite.ConsultarDatosSql(Query);
            return resp;
        }
        public DataTable ConsultarProducto()
        {
            string Query = "select * from Tbl_Inventario";
            DataTable table = conexionSQLite.Consultartable(Query);
            return table;
        }
    }
}
