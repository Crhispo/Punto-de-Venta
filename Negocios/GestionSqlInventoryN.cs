using Datos;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class GestionSqlInventoryN
    {
        readonly GestionSqlInventory gestionSqlInventory = new GestionSqlInventory();
        public int InsertarProductoN(string producto, string categoria, string precio, string cantdad, string codigo)
        {
            return gestionSqlInventory.InsertarProducto(producto, categoria, precio, cantdad, codigo);
        }
        public int ModificarProductoN(string id, string producto, string categoria, string precio, string cantdad, string codigo)
        {
            return gestionSqlInventory.ModificarProducto(id, producto, categoria, precio, cantdad, codigo);
        }
        public int EliminarPrductoN(string id)
        {
            return gestionSqlInventory.EliminarProducto(id);
        }
        public List<string> ConsultaInventarioN(string codigo)
        {
            return gestionSqlInventory.ConsultaInventario(codigo);

        }
        public DataTable ConsultaDTProduct()
        {
            return gestionSqlInventory.ConsultarProducto();
        }

    }
}
