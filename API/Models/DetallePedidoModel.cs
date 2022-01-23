using System.ComponentModel.DataAnnotations;

namespace CeciMedina.API.Models
{
    public class DetallePedidoModel
    {
        [Required]
        public int PedidoId { get; set; }
        
        [Required]
        public int ProductoId { get; set; }
        
        [Required]
        public decimal PrecioBase { get; set; }
        
        [Required]
        public decimal Iva { get; set; }
        
        [Required]
        public decimal Descuento { get; set; }
        
        [Required]
        public int Cantidad { get; set; }
        
        [Required]
        public decimal Subtotal { get; set; }
    }
}