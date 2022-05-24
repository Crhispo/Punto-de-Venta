using Datos;
using System.Collections.Generic;
using System.Data;
namespace Negocios
{
    public class GestionSqlClientN
    {
        readonly GestionSqlClient gestionSqlClient = new GestionSqlClient();
        public List<string> ConsultaCliente(string codigocliente)
        {
            return gestionSqlClient.ConsultarCliente(codigocliente);
        }

        public int InsertarClienteN(string nombre, string apellidos, string telefono, string correo, string codigocliente, string descuento, string cantcompras)
        {
            return gestionSqlClient.InsertarCliente(nombre, apellidos, telefono, correo, codigocliente, descuento, cantcompras);
        }
        public int ModificarClienteN(string id, string nombre, string apellidos, string telefono, string correo, string codigocliente, string descuento, string cantcompras)
        {
            return gestionSqlClient.ModificarCliente(id, nombre, apellidos, telefono, correo, codigocliente, descuento, cantcompras);
        }
        public int EliminarClienteN(string id)
        {
            return gestionSqlClient.EliminarCliente(id);
        }
        public DataTable ConsultaDTClients()
        {
            return gestionSqlClient.ConsultarClientes();
        }
    }
}
