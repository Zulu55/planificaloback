namespace Planificalo.Shared.Entities
{
    public class CotizacionProducto
    {
        public int CotizacionId { get; set; }
        public Cotizacion Cotizacion { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}