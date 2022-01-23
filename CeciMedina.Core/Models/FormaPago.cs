using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CeciMedina.Core.Models
{
    public class FormaPago : BaseEntity
    {
        public string Nombre { get; set; }
        public bool UsaCaja { get; set; }
    }
}