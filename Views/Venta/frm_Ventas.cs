using SistemaFacturacionParcial2.Controllers;
using SistemaFacturacionParcial2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaFacturacionParcial2.Views.Venta
{
    public partial class frm_Ventas : Form
    {
        private int stockDisponible = 0;
        private decimal precioUnitario = 0;
        private string codigoSeleccionado = "";

        private DataTable productosOriginal;
        private List<ClienteModel> clientesOriginal;

        public frm_Ventas()
        {
            InitializeComponent();
            dgvProductos.CellClick += dgvProductos_CellClick;
        }

        private void frm_Ventas_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarClientes();
        }

        private void CargarProductos()
        {
            ProductoController pc = new ProductoController();
            var productos = pc.ObtenerProductos();

            productosOriginal = new DataTable();
            productosOriginal.Columns.Add("Código");
            productosOriginal.Columns.Add("Descripción");
            productosOriginal.Columns.Add("Stock");
            productosOriginal.Columns.Add("Precio");

            foreach (var p in productos)
            {
                productosOriginal.Rows.Add(p.Codigo, p.Descripcion, p.Stock, p.PrecioVenta);
            }

            dgvProductos.DataSource = productosOriginal;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarClientes()
        {
            ClienteController cc = new ClienteController();
            clientesOriginal = cc.ObtenerClientes();

            cbClientes.DataSource = clientesOriginal;
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "Id";

            dgvClientes.DataSource = clientesOriginal;
            if (dgvClientes.Columns["Id"] != null)
                dgvClientes.Columns["Id"].Visible = false;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvProductos.Rows[e.RowIndex];

                if (fila.Cells["Stock"].Value == DBNull.Value || fila.Cells["Precio"].Value == DBNull.Value)
                    return;

                lblProductoSeleccionado.Text = fila.Cells["Descripción"].Value?.ToString() ?? "-";
                lblStock.Text = fila.Cells["Stock"].Value?.ToString() ?? "-";
                lblPrecioUnitario.Text = fila.Cells["Precio"].Value?.ToString() ?? "-";

                stockDisponible = Convert.ToInt32(fila.Cells["Stock"].Value);
                precioUnitario = Convert.ToDecimal(fila.Cells["Precio"].Value);
                codigoSeleccionado = fila.Cells["Código"].Value?.ToString();

                lblTotal.Text = "0.00";
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                if (cantidad > stockDisponible)
                {
                    lblTotal.Text = "0.00";
                    MessageBox.Show("No hay suficiente stock.");
                }
                else
                {
                    lblTotal.Text = (precioUnitario * cantidad).ToString("0.00");
                }
            }
            else
            {
                lblTotal.Text = "0.00";
            }
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex == -1 || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            int cantidad = int.Parse(txtCantidad.Text);

            if (cantidad > stockDisponible)
            {
                MessageBox.Show("Stock insuficiente.");
                return;
            }

            ProductoController pc = new ProductoController();
            int productoId = pc.ObtenerIdPorCodigo(codigoSeleccionado);

            VentaModel venta = new VentaModel()
            {
                ProductoId = productoId,
                ClienteId = Convert.ToInt32(cbClientes.SelectedValue),
                FechaVenta = DateTime.Now,
                Cantidad = cantidad,
                PrecioTotal = precioUnitario * cantidad,
                FacturaVenta = "FACT-" + Guid.NewGuid().ToString().Substring(0, 6),
                Estado = "Activa"
            };

            VentaController vc = new VentaController();
            vc.RegistrarVenta(venta);

            MessageBox.Show("Venta registrada correctamente.");
            LimpiarCampos();
            CargarProductos(); // Actualiza stock
        }

        private void LimpiarCampos()
        {
            lblProductoSeleccionado.Text = "-";
            lblStock.Text = "-";
            lblPrecioUnitario.Text = "-";
            lblTotal.Text = "0.00";
            txtCantidad.Text = "";
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var clienteForm = new Cliente.frm_Clientes();
            clienteForm.ShowDialog();
            CargarClientes();
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedItem is ClienteModel cliente)
                dgvClientes.DataSource = new List<ClienteModel> { cliente };
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            var historial = new frm_HistorialVentas();
            historial.ShowDialog();
        }

        private void txtBuscarProd_TextChanged(object sender, EventArgs e)
        {
            if (productosOriginal == null) return;

            string filtro = txtBuscarProd.Text.Trim().ToLower();
            DataView vista = productosOriginal.DefaultView;
            vista.RowFilter = $"Convert([Código], 'System.String') LIKE '%{filtro}%' OR [Descripción] LIKE '%{filtro}%'";
            dgvProductos.DataSource = vista.ToTable();
        }

        private void txtBuscarCli_TextChanged(object sender, EventArgs e)
        {
            if (clientesOriginal == null) return;

            string filtro = txtBuscarCli.Text.Trim().ToLower();

            var clientesFiltrados = clientesOriginal.FindAll(c =>
                c.Nombre.ToLower().Contains(filtro) ||
                c.Identificacion.ToLower().Contains(filtro));

            dgvClientes.DataSource = clientesFiltrados;
        }
    }
}
