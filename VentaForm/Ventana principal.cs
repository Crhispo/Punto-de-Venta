using Entidades;
using Negocios;
using Presentacion;
using System.Data;
using System.Drawing.Printing;
namespace VentaForm
{
    public partial class VentanaPrincipal : Form
    {
        readonly GestionSqlInvoicingN gestionSqlInvoicingN = new();
        readonly GestionSqlInventoryN gestionSqliInventoryN = new();
        readonly GestionSqlClientN gestionSqlClientN = new();
        private readonly DataTable dt;
        private double subtotal = 0;
        private double total = 0;
        private int desc;
        public VentanaPrincipal()
        {
            InitializeComponent();
            TBNumFact.Text = gestionSqlInvoicingN.ExtraerNumFact()[0];
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
        private void MiClientes_Click(object sender, EventArgs e)
        {
            Formulario_Cliente FU = new();
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

            List<string> consulta = gestionSqliInventoryN.ConsultaInventarioN(TBCodigoProducto.Text);
            row["Codigo"] = TBCodigoProducto.Text;
            row["Producto"] = consulta[0];
            row["Precio x Unidad"] = consulta[1].Replace(",", ".");
            row["Cantidad"] = TBCantidad.Text;
            row["Descuento"] = TBDescuento.Text.Replace(",", ".");
            row["Precio Total"] = double.Parse(TBCantidad.Text) * double.Parse(consulta[1].Replace(",", "."));

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
            List<string> consulta = gestionSqlClientN.ConsultaCliente(TBCodigoCliente.Text);
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
                factura.Total = total.ToString().Replace(",", ".");
                factura.NumFact = TBNumFact.Text;

                ListaFactura.Add(factura);
            }
            gestionSqlInvoicingN.InsertarFacturaN(ListaFactura);
            TBNumFact.Text = gestionSqlInvoicingN.ExtraerNumFact()[0];

            ReporteFactura = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ReporteFactura.PrinterSettings = ps;
            ReporteFactura.PrintPage += ImprimirFactura;
            ReporteFactura.Print();

        }

        private void ImprimirFactura(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int ancho = 300;
            int alt = 300;
            int y = 20;
            int x = 40;
            e.Graphics.DrawString($"--- Punto de venta ---\n Numero de factura: {TBNumFact.Text} \n Cliente: {TBNombreCliente.Text} \n ---- Productos ----\n\n", font, Brushes.Black, new RectangleF(x, y+= 40, ancho, alt));
            e.Graphics.DrawString($"------------------------------------------", font, Brushes.Black, new RectangleF(x, y += 90, ancho, alt));
            foreach (DataRow row in dt.Rows)
            {
                
                e.Graphics.DrawString($"\nId: {row["Codigo"]} \nProducto: {row["Producto"]} \nPrecio: {row["Precio Total"]}\n", font, Brushes.Black, new RectangleF(x, y += 10, ancho, alt));
                e.Graphics.DrawString($"------------------------", font, Brushes.Black, new RectangleF(x, y += 80, ancho, alt));
            }
            e.Graphics.DrawString($"\n---- Aponderado ---- \nSubtotal: {subtotal} \nTotal: ${total} \n---- Gracias por su compra ----", font, Brushes.Black, new RectangleF(x, y += 20, ancho, alt));
        }
    }
}
