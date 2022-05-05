using Datos;
using System.Data;

namespace Negocios
{
    public class ConexionSQLiteN
    {
        readonly ConexionSQLite ConexionSQLite = new ConexionSQLite();

        public int ConSQLite(string user, string pass)
        {
            return ConexionSQLite.ConsultaLogin(user, pass);
        }

        public DataTable ConsultaDT()
        {
            return ConexionSQLite.ConsultarUsuarios();
        }
    }
}
