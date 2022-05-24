using Negocios;
namespace Presentacion
{
    public partial class FormInventory : Form
    {
        private static readonly GestionSqlInventoryN gestionSqlInventoryN = new();
        public FormInventory()
        {
            InitializeComponent();
            DGInventory.DataSource = gestionSqlInventoryN.ConsultaDTProduct();
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnElminarProduct_Click(object sender, EventArgs e)
        {
            int Data = gestionSqlInventoryN.EliminarPrductoN(TBId.Text);
            if (Data == 1)
            {
                MessageBox.Show($"Se elimino con exito el producto con el id : {TBId.Text}");
            }
            else
            {
                MessageBox.Show($"No se pudo elimanr el producto con el dni : {TBId.Text}");
            }
            DGInventory.DataSource = gestionSqlInventoryN.ConsultaDTProduct();
        }
        private void BtnActualizarProduct_Click(object sender, EventArgs e)
        {
            int Data = gestionSqlInventoryN.ModificarProductoN(TBId.Text, TBProducto.Text, TBCategoria.Text, TBPrecio.Text, TBCantidad.Text, TBCodigo.Text);
            if (Data == 1)
            {
                MessageBox.Show($"Se actualizo con exito el producto con id : {TBId.Text}");
            }
            else
            {
                MessageBox.Show($"No se pudo actualizo el producto con dni : {TBId.Text}");
            }
            DGInventory.DataSource = gestionSqlInventoryN.ConsultaDTProduct();
        }
        private void BtnNuevoProduct_Click(object sender, EventArgs e)
        {
            gestionSqlInventoryN.InsertarProductoN(TBProducto.Text, TBCategoria.Text, TBPrecio.Text, TBCantidad.Text, TBCodigo.Text);
            DGInventory.DataSource = gestionSqlInventoryN.ConsultaDTProduct();
        }
        private void BtnBuscarId_Click(object sender, EventArgs e)
        {

        }
    }
}
