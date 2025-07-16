namespace SistemaFacturacionParcial2.Models
{
    public class VentaModel
    {
        public int ProductoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioTotal { get; set; }
        public string FacturaVenta { get; set; }
        public string Estado { get; set; }

        // Estas dos propiedades son necesarias para mostrar en el historial
        public string NombreCliente { get; set; }
        public string NombreProducto { get; set; }
    }
}
