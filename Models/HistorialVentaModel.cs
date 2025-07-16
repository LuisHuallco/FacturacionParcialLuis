namespace SistemaFacturacionParcial2.Models
{
    public class HistorialVentaModel
    {
        public string FacturaVenta { get; set; }
        public string NombreProducto { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioTotal { get; set; }
        public string Estado { get; set; }
        public int GarantiaDias { get; set; }
    }
}
