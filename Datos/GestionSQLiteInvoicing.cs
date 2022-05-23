using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public class GestionSQLiteInvoicing
    {
        readonly ConexionSQLite conexionSQLite = new ConexionSQLite();
        public List<string> Consultanumfact()
        {
            string Query = "Select(Select Top 1 numfact from Tbl_Facturacion order by numfact desc) +1 as numfact";
            List<string> resp = conexionSQLite.ConsultarDatosSQLite(Query);
            return resp;
        }
        public int InsertarFactura(List<Factura> ObjectFactura)
        {
            int flag = 0;
            foreach (var factura in ObjectFactura)
            {
                string Query = $"INSERT INTO Tbl_Facturacion (codigo, producto, precioxunidad, cantidad, codigocliente, descuentocliente, montototal, numfact) VALUES ('{factura.Codigo}','{factura.Producto}',{factura.PrecioxUnidad},{factura.Cantidad},'{factura.Cliente}',{factura.ClienteDesc},{factura.Total},{factura.NumFact})";
                flag = conexionSQLite.QuerySQLiteAsync(Query);
                int resp = flag;
            }
            return flag;
        }
    }
}