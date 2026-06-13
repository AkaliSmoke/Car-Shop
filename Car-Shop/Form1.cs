namespace Car_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes telaClientes = new FormClientes();
            telaClientes.ShowDialog();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            FormVeiculos telaVeiculos = new FormVeiculos();
            telaVeiculos.ShowDialog();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FormVendedor telaVendedor = new FormVendedor();
            telaVendedor.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
