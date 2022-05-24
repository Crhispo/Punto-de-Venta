using Negocios;
namespace Presentacion
{
    public partial class FormUsers : Form
    {
        readonly GestionSqlUsersN gestionSqlUsersN = new();
        public FormUsers()
        {
            InitializeComponent();
            DGUsers.DataSource = gestionSqlUsersN.ConsultaDTUsers();
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnNuevoUser_Click(object sender, EventArgs e)
        {
            gestionSqlUsersN.InsertarUsuarioN(TBNombre.Text, TBApellidos.Text, TBDNI.Text, TBTelefono.Text, TBUsuario.Text, TBClave.Text);
            DGUsers.DataSource = gestionSqlUsersN.ConsultaDTUsers();
        }

        private void BtnActualizarUser_Click(object sender, EventArgs e)
        {
            int Data = gestionSqlUsersN.ModificarUsuarioN(TBNombre.Text, TBApellidos.Text, TBDNI.Text, TBTelefono.Text, TBUsuario.Text, TBClave.Text);
            if (Data == 1)
            {
                MessageBox.Show($"Se actualizo con exito el usuario con dni : {TBDNI.Text}");
            }
            else
            {
                MessageBox.Show($"No se pudo actualizo el usuario con dni : {TBDNI.Text}");
            }
            DGUsers.DataSource = gestionSqlUsersN.ConsultaDTUsers();
        }
        private void BtnEliminarUser_Click(object sender, EventArgs e)
        {
            int Data = gestionSqlUsersN.EliminarUsuarioN(TBDNI.Text);
            if (Data == 1)
            {
                MessageBox.Show($"Se elimino con exito el usuario con el dni : {TBDNI.Text}");
            }
            else
            {
                MessageBox.Show($"No se pudo elimanr el usuario con el dni : {TBDNI.Text}");
            }
            DGUsers.DataSource = gestionSqlUsersN.ConsultaDTUsers();
        }
    }
}
