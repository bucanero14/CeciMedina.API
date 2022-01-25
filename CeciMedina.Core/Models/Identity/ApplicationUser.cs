using System;
using Microsoft.AspNetCore.Identity;

namespace CeciMedina.Core.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
    }
}