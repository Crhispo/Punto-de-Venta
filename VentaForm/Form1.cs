using Negocios;

namespace VentaForm
{
    public partial class Login : Form
    {
        readonly ConexionSQLiteN CNN = new();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbUser_Click(object sender, EventArgs e)
        {

        }

        private void LbClave_Click(object sender, EventArgs e)
        {

        }

        private void TbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BtnIniciar_Click(object sender, EventArgs e)
        {
           
            if (CNN.ConSQLite(TbUser.Text, TbPassword.Text) == 1)
            {
                MessageBox.Show("El usuario a sido encontrado");
            }
            else
            {
                MessageBox.Show("El usuario no a sido encontrado");
            }
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}