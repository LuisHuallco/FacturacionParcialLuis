using MySql.Data.MySqlClient;
using SistemaFacturacionParcial2.Models;
using System;
using System.Collections.Generic;

namespace SistemaFacturacionParcial2.Controllers
{
    public class VentaController
    {
        // ✅ Registrar nueva venta
        public void RegistrarVenta(VentaModel venta)
        {
            using (MySqlConnection con = new SistemaFacturacionParcial2.Conexion.Conexion().ObtenerConexion())
            {
                

                // Insertar la venta
                string queryVenta = @"INSERT INTO ventas (producto_id, cliente_id, fecha_venta, cantidad, precio_total, factura_venta, estado)
                                      VALUES (@producto_id, @cliente_id, @fecha_venta, @cantidad, @precio_total, @factura_venta, @estado)";
                MySqlCommand cmd = new MySqlCommand(queryVenta, con);
                cmd.Parameters.AddWithValue("@producto_id", venta.ProductoId);
                cmd.Parameters.AddWithValue("@cliente_id", venta.ClienteId);
                cmd.Parameters.AddWithValue("@fecha_venta", venta.FechaVenta);
                cmd.Parameters.AddWithValue("@cantidad", venta.Cantidad);
                cmd.Parameters.AddWithValue("@precio_total", venta.PrecioTotal);
                cmd.Parameters.AddWithValue("@factura_venta", venta.FacturaVenta);
                cmd.Parameters.AddWithValue("@estado", venta.Estado);
                cmd.ExecuteNonQuery();

                // Actualizar el stock
                string queryStock = @"UPDATE productos SET stock = stock - @cantidad WHERE id = @producto_id";
                MySqlCommand cmdStock = new MySqlCommand(queryStock, con);
                cmdStock.Parameters.AddWithValue("@cantidad", venta.Cantidad);
                cmdStock.Parameters.AddWithValue("@producto_id", venta.ProductoId);
                cmdStock.ExecuteNonQuery();
            }
        }

        // ✅ Obtener historial de ventas
        public List<VentaModel> ObtenerHistorialVentas()
        {
            var lista = new List<VentaModel>();

            using (var con = new Conexion.Conexion().ObtenerConexion())
            {
               
                string query = @"SELECT v.factura_venta, v.fecha_venta, v.cantidad, v.precio_total, v.estado,
                                        c.nombre AS nombre_cliente, p.descripcion AS nombre_producto
                                 FROM ventas v
                                 JOIN clientes c ON v.cliente_id = c.id
                                 JOIN productos p ON v.producto_id = p.id";

                using (var cmd = new MySqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new VentaModel
                        {
                            FacturaVenta = reader["factura_venta"].ToString(),
                            FechaVenta = Convert.ToDateTime(reader["fecha_venta"]),
                            Cantidad = Convert.ToInt32(reader["cantidad"]),
                            PrecioTotal = Convert.ToDecimal(reader["precio_total"]),
                            Estado = reader["estado"].ToString(),
                            NombreCliente = reader["nombre_cliente"].ToString(),
                            NombreProducto = reader["nombre_producto"].ToString()
                        });
                    }
                }
            }

            return lista;
        }

        // ✅ Anular una venta
        public void AnularVentaPorFactura(string factura)
        {
            using (var con = new Conexion.Conexion().ObtenerConexion())
            {
                con.Open();
                string query = "UPDATE ventas SET estado = 'Anulada' WHERE factura_venta = @factura";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@factura", factura);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
