using SistemaFacturacionParcial2.Controllers;
using SistemaFacturacionParcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaFacturacionParcial2.Views.Producto
{
    public partial class frm_AgregarStock : Form
    {
        private ProductoController productoController = new ProductoController();
        private ProductoModel productoSeleccionado;

        public frm_AgregarStock()
        {
            InitializeComponent();
            this.Load += frm_AgregarStock_Load;
            this.dgvProductos.CellClick += dgvProductos_CellClick;
            this.txtBuscarDescripcion.TextChanged += txtBuscarDescripcion_TextChanged;
            this.btnGuardarStock.Click += btnGuardarStock_Click;
        }

        private void frm_AgregarStock_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            var productos = productoController.ObtenerProductos();

            var tabla = new System.Data.DataTable();
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("PrecioVenta");
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Stock");

            foreach (var p in productos)
            {
                tabla.Rows.Add(p.Descripcion, p.PrecioVenta, p.Codigo, p.Stock);
            }

            dgvProductos.DataSource = tabla;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvProductos.Rows[e.RowIndex];

                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                lblStockActual.Text = fila.Cells["Stock"].Value.ToString();

                // Guardar producto seleccionado para el guardado
                productoSeleccionado = productoController.ObtenerProductos()
                    .FirstOrDefault(p => p.Codigo == txtCodigo.Text);
            }
        }

        private void btnGuardarStock_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            if (!int.TryParse(txtCantidadAgregar.Text, out int cantidad) || cantidad < 1)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            productoController.AgregarStock(productoSeleccionado.Id, cantidad);
            MessageBox.Show("Stock actualizado correctamente.");

            CargarProductos();
            Limpiar();
        }

        private void txtBuscarDescripcion_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarDescripcion.Text.ToLower();

            var productos = productoController.ObtenerProductos()
                .Where(p => p.Descripcion.ToLower().Contains(filtro))
                .ToList();

            var tabla = new System.Data.DataTable();
            tabla.Columns.Add("Descripcion");
            tabla.Columns.Add("PrecioVenta");
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Stock");

            foreach (var p in productos)
            {
                tabla.Rows.Add(p.Descripcion, p.PrecioVenta, p.Codigo, p.Stock);
            }

            dgvProductos.DataSource = tabla;
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCantidadAgregar.Text = "";
            lblStockActual.Text = "-";
            productoSeleccionado = null;
        }
    }
}
