using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocios
{
    public class GestionSQLiteInvoicingN
    {
        readonly GestionSQLiteInvoicing GestionSQLiteInvoicing = new GestionSQLiteInvoicing();
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
