using SistemaFacturacionParcial2.Controllers;
using SistemaFacturacionParcial2.Models;
using System;
using System.Windows.Forms;

namespace SistemaFacturacionParcial2.Views.Cliente
{
    public partial class frm_Clientes : Form
    {
        ClienteController controller = new ClienteController();

        
            public frm_Clientes()
        {
            InitializeComponent();
            CargarClientes();
            dgvClientes.ClearSelection();  
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            Limpiar();
        }

        

       
           private void CargarClientes()
        {
            dgvClientes.SelectionChanged -= dgvClientes_SelectionChanged; 

            dgvClientes.DataSource = controller.ObtenerClientes();       
            dgvClientes.ClearSelection();                              
            Limpiar();                                                  

            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged; 
        }

        

        private void Limpiar()
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteModel cliente = new ClienteModel
                {
                    Nombre = txtNombre.Text,
                    Identificacion = txtIdentificacion.Text,
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text
                };

                controller.AgregarCliente(cliente);
                MessageBox.Show("Cliente guardado correctamente.");
                CargarClientes();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);

                    ClienteModel cliente = new ClienteModel
                    {
                        Id = id,
                        Nombre = txtNombre.Text,
                        Identificacion = txtIdentificacion.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text
                    };

                    controller.EditarCliente(cliente);
                    MessageBox.Show("Cliente actualizado correctamente.");
                    CargarClientes();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar cliente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente de la tabla para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);
                DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    controller.EliminarCliente(id);
                    MessageBox.Show("Cliente eliminado.");
                    CargarClientes();
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente de la tabla para eliminar.");
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var fila = dgvClientes.SelectedRows[0];

                txtNombre.Text = fila.Cells["Nombre"]?.Value?.ToString() ?? "";
                txtIdentificacion.Text = fila.Cells["Identificacion"]?.Value?.ToString() ?? "";
                txtEmail.Text = fila.Cells["Email"]?.Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Telefono"]?.Value?.ToString() ?? "";
            }
        }


    }
}
