using Presentacion;

namespace VentaForm
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
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
    }
}
