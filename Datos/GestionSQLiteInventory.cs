using System.Data;

namespace Datos
{
    public class GestionSQLiteInventory
    {
        readonly ConexionSQLite conexionSQLite = new ConexionSQLite();
        private int flag;
        /*
        Codigo numerico tipo de Query
        Consulta Login = 0
        Modificar datos de tabla = 1
        */
        public int InsertarProducto(string producto, string categoria, string precio, string cantidad)
        {
            string Query = $"Insert into Tbl_Inventario (producto, categoria, precio, cantidad) values ('{producto}', '{categoria}', {precio}, {cantidad})";
            flag = conexionSQLite.QuerySQLite(Query, 1);
            return flag;
        }
        public int ModificarProducto(string id, string producto, string categoria, string precio, string cantidad)
        {
            string Query = $"Update Tbl_Inventario set producto = '{producto}', categoria = '{categoria}', precio = {precio}, telefono = {cantidad} where id = {id}";
            flag = conexionSQLite.QuerySQLite(Query, 1);
            return flag;
        }
        public int EliminarProducto(string id)
        {
            string Query = $"delete from Tbl_Inventario where id = {id}";
            flag = conexionSQLite.QuerySQLite(Query, 1);
            return flag;
        }
        public DataTable ConsultarProducto()
        {
            string Query = "select * from Tbl_Inventario";
            DataTable table = conexionSQLite.ConsultarUsers(Query);
            return table;
        }
    }
}
