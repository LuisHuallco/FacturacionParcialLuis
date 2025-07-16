using SistemaFacturacionParcial2.Controllers;
using SistemaFacturacionParcial2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionParcial2.Views.Producto
{
    public partial class frm_NuevoProducto : Form
    {
        public frm_NuevoProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoModel producto = new ProductoModel
                {
                    Codigo = txtCodigo.Text,
                    Descripcion = txtDescripcion.Text,
                    PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                    PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                    Stock = Convert.ToInt32(txtStock.Text),
                    FechaCompra = DateTime.Now, // Puedes agregar DateTimePicker si lo deseas
                    Estado = "Activo"
                };

                ProductoController controller = new ProductoController();
                controller.AgregarProducto(producto);

                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
