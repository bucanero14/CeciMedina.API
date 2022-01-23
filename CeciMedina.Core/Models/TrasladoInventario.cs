namespace CeciMedina.Core.Models
{
    public class TrasladoInventario : BaseEntity
    {
        public Traslado Traslado { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}