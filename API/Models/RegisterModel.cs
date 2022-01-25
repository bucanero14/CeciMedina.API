using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CeciMedina.API.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Roles are required")]
        public List<string> Roles { get; set; }
    }
}
