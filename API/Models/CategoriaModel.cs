using System.ComponentModel.DataAnnotations;

namespace CeciMedina.API.Models
{
    public class CategoriaModel
    {
        [Required]
        public string Nombre { get; set; }
    }
}
