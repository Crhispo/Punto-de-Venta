using Datos;
using System.Collections.Generic;
namespace Negocios
{
    public class GestionSQLiteClientN
    {
        readonly GestionSQLiteClient GestionSQLiteClient = new GestionSQLiteClient();
        public List<string> ConsultaCliente(string codigocliente)
        {
            return GestionSQLiteClient.ConsultarCliente(codigocliente);
        }
    }
}
