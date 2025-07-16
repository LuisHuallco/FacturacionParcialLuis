using SistemaFacturacionParcial2.Controllers;
using SistemaFacturacionParcial2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaFacturacionParcial2.Views.Venta
{
    public partial class frm_HistorialVentas : Form
    {
        private VentaController ventaController = new VentaController();
        private List<VentaModel> ventas = new List<VentaModel>();

        public frm_HistorialVentas()
        {
            InitializeComponent();
        }

        private void frm_HistorialVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void CargarVentas()
        {
            ventas = ventaController.ObtenerHistorialVentas();

            var tabla = new DataTable();
            tabla.Columns.Add("Factura");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Cliente");
            tabla.Columns.Add("Fecha Venta");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Total");
            tabla.Columns.Add("Estado");

            foreach (var v in ventas)
            {
                tabla.Rows.Add(v.FacturaVenta, v.NombreProducto, v.NombreCliente, v.FechaVenta.ToShortDateString(), v.Cantidad, v.PrecioTotal.ToString("0.00"), v.Estado);
            }

            dgvHistorialVentas.DataSource = tabla;
            dgvHistorialVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarFactura.Text.ToLower();
            var resultados = ventas.Where(v =>
                v.FacturaVenta.ToLower().Contains(filtro) ||
                v.NombreCliente.ToLower().Contains(filtro) ||
                v.NombreProducto.ToLower().Contains(filtro)).ToList();

            var tabla = new DataTable();
            tabla.Columns.Add("Factura");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Cliente");
            tabla.Columns.Add("Fecha Venta");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Total");
            tabla.Columns.Add("Estado");

            foreach (var v in resultados)
            {
                tabla.Rows.Add(v.FacturaVenta, v.NombreProducto, v.NombreCliente, v.FechaVenta.ToShortDateString(), v.Cantidad, v.PrecioTotal.ToString("0.00"), v.Estado);
            }

            dgvHistorialVentas.DataSource = tabla;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnAnularVenta_Click(object sender, EventArgs e)
        {
            if (dgvHistorialVentas.SelectedRows.Count > 0)
            {
                string factura = dgvHistorialVentas.SelectedRows[0].Cells["Factura"].Value.ToString();

                var confirm = MessageBox.Show($"¿Seguro que deseas anular la venta {factura}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    ventaController.AnularVentaPorFactura(factura);
                    MessageBox.Show("Venta anulada correctamente.");
                    CargarVentas();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta para anular.");
            }
        }
    }
}
