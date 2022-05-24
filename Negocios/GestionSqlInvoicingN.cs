using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocios
{
    public class GestionSqlInvoicingN
    {
        readonly GestionSqlInvoicing GestionSQLiteInvoicing = new GestionSqlInvoicing();
        public List<string> ExtraerNumFact()
        {
            return GestionSQLiteInvoicing.Consultanumfact();
        }
        public int InsertarFacturaN(List<Factura> ObjectFactura)
        {
            return GestionSQLiteInvoicing.InsertarFactura(ObjectFactura);
        }
    }
}
