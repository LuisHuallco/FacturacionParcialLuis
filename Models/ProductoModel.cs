namespace SistemaFacturacionParcial2.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Codigo { get; set; }
        public int Stock { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Estado { get; set; }  // "Activo" o "Inactivo"
    }
}
