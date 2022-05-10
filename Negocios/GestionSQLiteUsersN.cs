using Datos;
using System.Data;

namespace Negocios
{
    public class GestionSQLiteUsersN
    {
        readonly GestionSQLiteUsers gestionSQLiteUsers = new GestionSQLiteUsers();

        public int ConSQLite(string user, string pass)
        {
            return gestionSQLiteUsers.ConsultaLogin(user, pass);
        }

        public int InsertarUsuarioN(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            return gestionSQLiteUsers.InsertarUsuario(nombre, apellidos, dni, telefono, usuario, clave);
        }

        public int ModificarUsuarioN(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            return gestionSQLiteUsers.ModificarUsuario(nombre, apellidos, dni, telefono, usuario, clave);
        }

        public int EliminarUsuarioN(string dni)
        {
            return gestionSQLiteUsers.EliminarUsuario(dni);
        }

        public DataTable ConsultaDTUsers()
        {
            return gestionSQLiteUsers.ConsultarUsuarios();
        }


    }
}
