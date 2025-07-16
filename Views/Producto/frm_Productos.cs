using SistemaFacturacionParcial2.Controllers;
using SistemaFacturacionParcial2.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFacturacionParcial2.Views.Producto
{
    public partial class frm_Productos : Form
    {
        private ProductoController controller = new ProductoController();

        public frm_Productos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            List<ProductoModel> productos = controller.ObtenerProductos();
            dgvProductos.DataSource = productos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_NuevoProducto nuevo = new frm_NuevoProducto();
            nuevo.ShowDialog();
            CargarProductos();
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int productoId = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value);

                // Crear instancia del formulario y pasar el ID del producto
                frm_AgregarStock agregar = new frm_AgregarStock();  // ✅ Sin argumentos
                agregar.ShowDialog();

                // Actualizar tabla de productos después de cerrar
                CargarProductos();
            }
        }


        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int productoId = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["Id"].Value);
                controller.DesactivarProducto(productoId);
                MessageBox.Show("Producto desactivado.");
                CargarProductos();
            }
        }

        private void frm_Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
