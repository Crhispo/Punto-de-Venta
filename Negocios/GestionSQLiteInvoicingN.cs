using Datos;
using System;

namespace Negocios
{
    public class GestionSQLiteInvoicingN
    {
        readonly GestionSQLiteInvoicing GestionSQLiteInvoicing = new GestionSQLiteInvoicing();
        public string ExtraerNumFact()
        {
            return GestionSQLiteInvoicing.Consultanumfact();
        }
        public Tuple<string, string> ConsultaInventarioN(string codigo)
        {
            return GestionSQLiteInvoicing.ConsultaInventario(codigo);

        }
    }
}
