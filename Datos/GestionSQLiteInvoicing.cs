using System;

namespace Datos
{
    public class GestionSQLiteInvoicing
    {
        readonly ConexionSQLite conexionSQLite = new ConexionSQLite();
        public string Consultanumfact()
        {
            string Query = "Select(Select numfact from Tbl_Facturacion order by numfact desc LIMIT 1) +1 as numfact";
            string resp = conexionSQLite.ConsultarNumFactSQLite(Query);
            return resp;
        }
        public Tuple<string,string> Consulafact(string codigo)
        {
            string Query = $"Select * from Tbl_Inventario where codigo = {codigo}";
            Tuple<string, string> resp = conexionSQLite.ConsultarDatosSQLite(Query);
            return resp;
        }
    }
}
