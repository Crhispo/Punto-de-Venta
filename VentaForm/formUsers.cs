using Negocios;

namespace Presentacion
{
    public partial class FormUsers : Form
    {
        readonly ConexionSQLiteN SQLiteN = new();
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void DGUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoUser_Click(object sender, EventArgs e)
        {
            DGUsers.DataSource = SQLiteN.ConsultaDT();
        }

        private void BtnActualizarUser_Click(object sender, EventArgs e)
        {
            DGUsers.DataSource = SQLiteN.ConsultaDT();
        }

        private void BtnEliminarUser_Click(object sender, EventArgs e)
        {
            DGUsers.DataSource = SQLiteN.ConsultaDT();
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
