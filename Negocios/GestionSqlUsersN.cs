using Datos;
using System.Data;

namespace Negocios
{
    public class GestionSqlUsersN
    {
        readonly GestionSqlUsers gestionSqlUsers = new GestionSqlUsers();

        public int ConSql(string user, string pass)
        {
            return gestionSqlUsers.ConsultaLogin(user, pass);
        }

        public int InsertarUsuarioN(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            return gestionSqlUsers.InsertarUsuario(nombre, apellidos, dni, telefono, usuario, clave);
        }

        public int ModificarUsuarioN(string nombre, string apellidos, string dni, string telefono, string usuario, string clave)
        {
            return gestionSqlUsers.ModificarUsuario(nombre, apellidos, dni, telefono, usuario, clave);
        }

        public int EliminarUsuarioN(string dni)
        {
            return gestionSqlUsers.EliminarUsuario(dni);
        }

        public DataTable ConsultaDTUsers()
        {
            return gestionSqlUsers.ConsultarUsuarios();
        }


    }
}
