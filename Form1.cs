namespace SistemaFacturacionParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Views.Cliente.frm_Clientes clientes = new Views.Cliente.frm_Clientes();
            clientes.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Views.Producto.frm_Productos productos = new Views.Producto.frm_Productos();
            productos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Views.Venta.frm_Ventas ventas = new Views.Venta.frm_Ventas();
            ventas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
