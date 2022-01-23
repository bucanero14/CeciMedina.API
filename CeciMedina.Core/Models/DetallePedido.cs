namespace CeciMedina.Core.Models
{
    public class DetallePedido : BaseEntity
    {
        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        public virtual int PedidoId { get; set; }
        public virtual int ProductoId { get; set; }
    }
}