using System.Collections.Generic;
namespace Datos
{
    public class GestionSQLiteClient
    {
        readonly ConexionSQLite conexionSQLite = new ConexionSQLite();
        public List<string> ConsultarCliente(string codigoCliente)
        {
            string Query = $"SELECT nombrecliente + ' ' + apellidocliente as nombrecompletocliente, descuento FROM Tbl_Cliente where codigocliente = '{codigoCliente}'";
            List<string> resp = conexionSQLite.ConsultarDatosSQLite(Query);
            return resp;
        }
    }
}
