using Presentacion;

namespace VentaForm
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mSAbrirFactura_Click(object sender, EventArgs e)
        {

        }

        private void MiUsuarios_Click(object sender, EventArgs e)
        {
            FormUsers FU = new();
            this.Hide();
            FU.ShowDialog();
            this.Show();
        }
    }
}
