using Entidades;
using Negocios;
using Presentacion;
using System.Data;
namespace VentaForm
{
    public partial class VentanaPrincipal : Form
    {
        readonly GestionSQLiteInvoicingN gestionSQLiteInvoicingN = new();
        readonly GestionSQLiteInventoryN gestionSQLiteInventoryN = new();
        readonly GestionSQLiteClientN gestionSQLiteClientN = new();
        private readonly DataTable dt;
        private double subtotal = 0;
        private double total = 0;
        private int desc;

        public VentanaPrincipal()
        {
            InitializeComponent();
            TBNumFact.Text = gestionSQLiteInvoicingN.ExtraerNumFact()[0];
            TBImpVentaRead.Text = (double.Parse(TBImpVenta.Text) * 100).ToString();
            TBDescuentoRead.Text = (double.Parse(TBDescuento.Text) * 100).ToString();

            dt = new DataTable();
            dt.Columns.Add("Codigo"); dt.Columns.Add("Producto"); dt.Columns.Add("Precio x Unidad"); dt.Columns.Add("Cantidad"); dt.Columns.Add("Descuento"); dt.Columns.Add("Precio Total");
            DtgFacturacion.DataSource = dt;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MiUsuarios_Click(object sender, EventArgs e)
        {
            FormUsers FU = new();
            this.Hide();
            FU.ShowDialog();
            this.Show();
        }
        private void MiInventario_Click(object sender, EventArgs e)
        {
            FormInventory FU = new();
            this.Hide();
            FU.ShowDialog();
            this.Show();
        }
        private void TBImpVenta_TextChanged(object sender, EventArgs e)
        {
            TBImpVentaRead.Text = (double.Parse(TBImpVenta.Text) * 100).ToString();
        }
        private void TBDescuento_TextChanged(object sender, EventArgs e)
        {
            TBDescuentoRead.Text = (double.Parse(TBDescuento.Text) * 100).ToString();
        }
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            List<string> consulta = gestionSQLiteInventoryN.ConsultaInventarioN(TBCodigoProducto.Text);
            row["Codigo"] = TBCodigoProducto.Text;
            row["Producto"] = consulta[0];
            row["Precio x Unidad"] = consulta[1].Replace(",", ".");
            row["Cantidad"] = TBCantidad.Text;
            row["Descuento"] = TBDescuento.Text.Replace(",",".");
            row["Precio Total"] = double.Parse(TBCantidad.Text) * double.Parse(consulta[1].Replace(",","."));

            dt.Rows.Add(row);
            subtotal += (int.Parse(TBCantidad.Text) * double.Parse(consulta[1]));

            desc = int.Parse(TBDescuentoRead.Text);

            switch (desc)
            {
                case 0:
                    total = subtotal + (subtotal * double.Parse(TBImpVenta.Text));
                    break;
                case > 0:
                    total = subtotal + (subtotal * double.Parse(TBImpVenta.Text));
                    total -= (total * double.Parse(TBDescuento.Text));
                    break;
            }

            LbValorSubtotal.Text = subtotal.ToString();
            LbValorTotal.Text = total.ToString();
        }
        private void BtnCodigoCliente_Click(object sender, EventArgs e)
        {
            List<string> consulta = gestionSQLiteClientN.ConsultaCliente(TBCodigoCliente.Text);
            TBNombreCliente.Text = consulta[0];
            TBDescuento.Text = consulta[1];
        }
        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            List<Factura> ListaFactura = new();
            foreach (DataRow row in dt.Rows)
            {
                Factura factura = new();

                factura.Codigo = row["Codigo"].ToString();
                factura.Producto = row["Producto"].ToString();
                factura.PrecioxUnidad = row["Precio x Unidad"].ToString();
                factura.Cantidad = row["Cantidad"].ToString();
                factura.ClienteDesc = row["Descuento"].ToString();
                factura.PrecioTotal = row["Precio Total"].ToString();
                factura.Cliente = TBCodigoCliente.Text;
                factura.Descuento = TBDescuento.Text;
                factura.Total = total.ToString().Replace(",",".");
                factura.NumFact = TBNumFact.Text;

                ListaFactura.Add(factura);
            }
            gestionSQLiteInvoicingN.InsertarFacturaN(ListaFactura);
            TBNumFact.Text = gestionSQLiteInvoicingN.ExtraerNumFact()[0];
        }
    }
}
