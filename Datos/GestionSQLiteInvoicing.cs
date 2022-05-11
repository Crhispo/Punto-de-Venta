namespace Datos
{
    public class GestionSQLiteInvoicing
    {
        readonly ConexionSQLite conexionSQLite = new ConexionSQLite();
        public string Consulatnumfact()
        {
            string Query = "Select(Select numfact from Tbl_Facturacion order by numfact desc LIMIT 1) +1 as numfact";
            string resp = conexionSQLite.ConsultarDatosSQLite(Query);
            return resp;
        }
    }
}
