using Negocios;
using Presentacion;
using System.Data;

namespace VentaForm
{
    public partial class VentanaPrincipal : Form
    {
        readonly GestionSQLiteInvoicingN gestionSQLiteInvoicingN = new();
        private readonly DataTable dt;
        public VentanaPrincipal()
        {

            InitializeComponent();
            TBNumFact.Text = gestionSQLiteInvoicingN.ExtraerNumFact();
            TBImpVentaRead.Text = TBImpVenta.Text;
            TBDescuentoRead.Text = TBDescuento.Text;

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio x Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");
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
            TBImpVentaRead.Text = TBImpVenta.Text;
        }
        private void TBDescuento_TextChanged(object sender, EventArgs e)
        {
            TBDescuentoRead.Text = TBDescuento.Text;
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            var consulta = gestionSQLiteInvoicingN.ConsultaInventarioN(TBCodigoProducto.Text);
            row["Codigo"] = TBCodigoProducto.Text;
            row["Producto"] = consulta.Item1;
            row["Precio x Unidad"] = consulta.Item2;
            row["Cantidad"] = TBCantidad.Text;
            row["Descuento"] = TBDescuentoRead.Text;
            row["Precio Total"] = int.Parse(TBCantidad.Text) * double.Parse(consulta.Item2);

            dt.Rows.Add(row);
        }
    }
}
