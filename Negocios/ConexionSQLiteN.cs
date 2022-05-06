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

        public int InsertarUsuarioN(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            return ConexionSQLite.InsertarUsuario(nombre, apellidos, dni, telefono, usuario, clave);
        }

        public int ModificarUsuarioN(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            return ConexionSQLite.ModificarUsuario(nombre, apellidos, dni, telefono, usuario, clave);
        }

        public int EliminarUsuarioN(string dni)
        {
            return ConexionSQLite.EliminarUsuario(dni);
        }

        public DataTable ConsultaDT()
        {
            return ConexionSQLite.ConsultarUsuarios();
        }


    }
}
