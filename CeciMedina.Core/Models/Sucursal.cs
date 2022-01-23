namespace CeciMedina.Core.Models
{
    public class Sucursal : BaseEntity
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool TienePv { get; set; }
    }
}