using Entidades;
using System.Collections.Generic;

namespace Datos
{
    public class GestionSQLiteInvoicing
    {
        readonly ConexionSQLite conexionSQLite = new ConexionSQLite();
        private int flag;

        public List<string> Consultanumfact()
        {
            string Query = "Select(Select numfact from Tbl_Facturacion order by numfact desc LIMIT 1) +1 as numfact";
            List<string> resp = conexionSQLite.ConsultarDatosSQLite(Query);
            return resp;
        }

        public int InsertarFactura(List<Factura> ObjectFactura)
        {
            foreach (Factura factura in ObjectFactura)
            {
                string Query = $"INSERT INTO Tbl_Facturacion (codigo, producto, precioxunidad, cantidad, codigocliente, descuentocliente, montototal, numfact) VALUES ('{factura.Codigo}','{factura.Producto}',{factura.PrecioxUnidad},{factura.Cantidad},'{factura.Cliente}','{factura.ClienteDesc}','{factura.Total}',{factura.NumFact})";
                flag = conexionSQLite.QuerySQLite(Query, 1);

            }
            return flag;
        }

    }
}