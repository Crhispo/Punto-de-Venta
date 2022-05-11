using Datos;
using System.Data;

namespace Negocios
{
    public class GestionSQLiteInventoryN
    {
        readonly GestionSQLiteInventory gestionSQLiteInventory = new GestionSQLiteInventory();
        public int InsertarProductoN(string producto, string categoria, string precio, string cantdad, string codigo)
        {
            return gestionSQLiteInventory.InsertarProducto(producto, categoria, precio, cantdad, codigo);
        }
        public int ModificarProductoN(string id, string producto, string categoria, string precio, string cantdad, string codigo)
        {
            return gestionSQLiteInventory.ModificarProducto(id, producto, categoria, precio, cantdad, codigo);
        }
        public int EliminarPrductoN(string id)
        {
            return gestionSQLiteInventory.EliminarProducto(id);
        }
        public DataTable ConsultaDTProduct()
        {
            return gestionSQLiteInventory.ConsultarProducto();
        }

    }
}
