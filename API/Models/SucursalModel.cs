using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CeciMedina.API.Models
{
    public class SucursalModel
    {
        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Direccion { get; set; }
        
        [Required]
        public string Telefono { get; set; }
        
        [DefaultValue(true)]
        public bool TienePv { get; set; }
    }
}