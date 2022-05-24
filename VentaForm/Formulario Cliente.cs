using Negocios;

namespace Presentacion
{
    public partial class Formulario_Cliente : Form
    {
        GestionSqlClientN gestionSqlClientN = new();
        string codigocliente = "";
        public Formulario_Cliente()
        {
            InitializeComponent();
            DGClients.DataSource = gestionSqlClientN.ConsultaDTClients();
        }

        private void BtnNuevoClient_Click(object sender, EventArgs e)
        {
            codigocliente = TBNombreCliente.Text.Substring(0, 3) + TBApellidoCliente.Text.Substring(0, 3);
            gestionSqlClientN.InsertarClienteN(TBNombreCliente.Text, TBApellidoCliente.Text, TBTelefonoCliente.Text, TBCorreoCliente.Text, codigocliente, TBDescuento.Text, TBClantidadCompras.Text);
            DGClients.DataSource = gestionSqlClientN.ConsultaDTClients();
        }

        private void BtnActualizarClient_Click(object sender, EventArgs e)
        {
            codigocliente = TBNombreCliente.Text.Substring(0, 3) + TBApellidoCliente.Text.Substring(0, 3);
            int Data = gestionSqlClientN.ModificarClienteN(TBId.Text, TBNombreCliente.Text, TBApellidoCliente.Text, TBTelefonoCliente.Text, TBCorreoCliente.Text, codigocliente, TBDescuento.Text, TBClantidadCompras.Text);
            if (Data == 1)
            {
                MessageBox.Show($"Se actualizo con exito el cliente con id : {TBId.Text}");
            }
            else
            {
                MessageBox.Show($"No se pudo actualizo el cliente con id : {TBId.Text}");
            }
            DGClients.DataSource = gestionSqlClientN.ConsultaDTClients();
        }

        private void BtnElminarClient_Click(object sender, EventArgs e)
        {
            int Data = gestionSqlClientN.EliminarClienteN(TBId.Text);
            if (Data == 1)
            {
                MessageBox.Show($"Se elimino con exito el cliente con el id : {TBId.Text}");
            }
            else
            {
                MessageBox.Show($"No se pudo eliminar el cliente con el id : {TBId.Text}");
            }
            DGClients.DataSource = gestionSqlClientN.ConsultaDTClients();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
