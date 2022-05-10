using Negocios;
namespace Presentacion
{
    public partial class FormUsers : Form
    {
        readonly GestionSQLiteUsersN SQLiteN = new();
        public FormUsers()
        {
            InitializeComponent();
        }
        private void FormUsers_Load(object sender, EventArgs e)
        {
            DGUsers.DataSource = SQLiteN.ConsultaDTUsers();
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnNuevoUser_Click(object sender, EventArgs e)
        {
            SQLiteN.InsertarUsuarioN(TBNombre.Text, TBApellidos.Text, TBDNI.Text, TBTelefono.Text, TBUsuario.Text, TBClave.Text);
            DGUsers.DataSource = SQLiteN.ConsultaDTUsers();
        }

        private void BtnActualizarUser_Click(object sender, EventArgs e)
        {
            int Data = SQLiteN.ModificarUsuarioN(TBNombre.Text, TBApellidos.Text, TBDNI.Text, TBTelefono.Text, TBUsuario.Text, TBClave.Text);
            if (Data == 1)
            {
                MessageBox.Show($"Se actualizo con exito el usuario con dni : {TBDNI.Text}");
            }
            else
            {
                MessageBox.Show($"No se pudo actualizo el usuario con dni : {TBDNI.Text}");
            }
            DGUsers.DataSource = SQLiteN.ConsultaDTUsers();
        }
        private void BtnEliminarUser_Click(object sender, EventArgs e)
        {
            int Data = SQLiteN.EliminarUsuarioN(TBDNI.Text);
            if (Data == 1)
            {
                MessageBox.Show($"Se elimino con exito el usuario con el dni : {TBDNI.Text}");
            }
            else
            {
                MessageBox.Show($"No se pudo elimanr el usuario con el dni : {TBDNI.Text}");
            }
            DGUsers.DataSource = SQLiteN.ConsultaDTUsers();
        }
    }
}
