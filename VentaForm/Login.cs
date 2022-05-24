using Negocios;
namespace VentaForm
{
    public partial class Login : Form
    {
        readonly GestionSqlUsersN CNN = new();
        public Login()
        {
            InitializeComponent();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (CNN.ConSql(TbUser.Text, TbPassword.Text) == 1)
            {
                MessageBox.Show("El usuario a sido encontrado");
                this.Hide();
                VentanaPrincipal VP = new();
                VP.Show();
            }
            else
            {
                MessageBox.Show("El usuario no a sido encontrado");
            }
        }
    }
}