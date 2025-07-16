using SistemaFacturacionParcial2.Models;
using SistemaFacturacionParcial2.Conexion;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SistemaFacturacionParcial2.Controllers
{
    public class ClienteController
    {
        private Conexion.Conexion conexion = new Conexion.Conexion();

        public List<ClienteModel> ObtenerClientes()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            string query = "SELECT * FROM clientes";

            using (var conn = conexion.ObtenerConexion())
            using (var cmd = new MySqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new ClienteModel
                    {
                        Id = reader.GetInt32("id"),
                        Nombre = reader.GetString("nombre"),
                        Email = reader.IsDBNull(2) ? "" : reader.GetString("email"),
                        Telefono = reader.IsDBNull(3) ? "" : reader.GetString("telefono"),
                        Identificacion = reader.IsDBNull(4) ? "" : reader.GetString("identificacion")
                    });
                }
            }

            return lista;
        }

        public void AgregarCliente(ClienteModel cliente)
        {
            string query = "INSERT INTO clientes (nombre, email, telefono, identificacion) VALUES (@nombre, @email, @telefono, @identificacion)";

            using (var conn = conexion.ObtenerConexion())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                cmd.ExecuteNonQuery();
            }
        }
        public void EditarCliente(ClienteModel cliente)
        {
            string query = "UPDATE clientes SET nombre=@nombre, email=@email, telefono=@telefono, identificacion=@identificacion WHERE id=@id";

            using (var conn = conexion.ObtenerConexion())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCliente(int id)
        {
            string query = "DELETE FROM clientes WHERE id=@id";

            using (var conn = conexion.ObtenerConexion())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}

