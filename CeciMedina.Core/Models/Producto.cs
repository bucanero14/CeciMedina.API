namespace CeciMedina.Core.Models
{
    public class Producto : BaseEntity
    {
        public Categoria Categoria { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public decimal PrecioFinal { get; set; }
    }
}