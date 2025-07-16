using SistemaFacturacionParcial2.Models;
using SistemaFacturacionParcial2.Conexion;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SistemaFacturacionParcial2.Controllers
{
    public class ProductoController
    {
        public int ObtenerIdPorCodigo(string codigo)
        {
            var productos = ObtenerProductos();
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            return producto?.Id ?? 0;
        }

        private Conexion.Conexion conexion = new Conexion.Conexion();

        public List<ProductoModel> ObtenerProductos()
        {
            List<ProductoModel> lista = new List<ProductoModel>();
            string query = "SELECT * FROM productos WHERE estado = 'Activo'";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new ProductoModel
                    {
                        Id = reader.GetInt32("id"),
                        Descripcion = reader.GetString("descripcion"),
                        PrecioCompra = reader.GetDecimal("precio_compra"),
                        PrecioVenta = reader.GetDecimal("precio_venta"),
                        Codigo = reader.GetString("codigo"),
                        Stock = reader.GetInt32("stock"),
                        FechaCompra = reader.GetDateTime("fecha_compra"),
                        Estado = reader.GetString("estado")
                    });
                }
            }

            return lista;
        }

        public void AgregarProducto(ProductoModel producto)
        {
            string query = "INSERT INTO productos (descripcion, precio_compra, precio_venta, codigo, stock, fecha_compra, estado) " +
                           "VALUES (@descripcion, @precioCompra, @precioVenta, @codigo, @stock, @fechaCompra, 'Activo')";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@precioCompra", producto.PrecioCompra);
                cmd.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@fechaCompra", producto.FechaCompra);

                cmd.ExecuteNonQuery();
            }
        }

        public void AgregarStock(int productoId, int cantidad)
        {
            string query = "UPDATE productos SET stock = stock + @cantidad WHERE id = @id";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@id", productoId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DesactivarProducto(int productoId)
        {
            string query = "UPDATE productos SET estado = 'Inactivo' WHERE id = @id";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", productoId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
