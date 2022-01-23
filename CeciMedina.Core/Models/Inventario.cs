namespace CeciMedina.Core.Models
{
    public class Inventario : BaseEntity
    {
        public Producto Producto { get; set; }
        public Sucursal Sucursal { get; set; }
        public decimal PrecioBase { get; set; }
        public decimal Iva { get; set; }
        public decimal Descuento { get; set; }
        public decimal PrecioFinal { get; set; }
        public int Existencia { get; set; }
        public int ExistenciaMinima { get; set; }
        public int ExistenciaMaxima { get; set; }
    }
}