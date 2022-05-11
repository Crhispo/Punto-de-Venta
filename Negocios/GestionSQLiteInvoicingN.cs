using Datos;

namespace Negocios
{
    public class GestionSQLiteInvoicingN
    {
        readonly GestionSQLiteInvoicing GestionSQLiteInvoicing = new GestionSQLiteInvoicing();
        public string ExtraerNumFact()
        {
            return GestionSQLiteInvoicing.Consulatnumfact();
        }
    }
}
