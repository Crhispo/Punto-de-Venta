namespace Entidades
{
    public class Factura
    {
        private string codigo = "";
        private string producto = "";
        private string precioxUnidad = "";
        private string cantidad = "";
        private string descuento = "";
        private string precioTotal = "";
        private string cliente = "";
        private string clienteDesc = "";
        private string total = "";
        private string numFact = "";

        public string Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public string PrecioxUnidad { get => precioxUnidad; set => precioxUnidad = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string ClienteDesc { get => clienteDesc; set => clienteDesc = value; }
        public string Total { get => total; set => total = value; }
        public string NumFact { get => numFact; set => numFact = value; }
    }
}
