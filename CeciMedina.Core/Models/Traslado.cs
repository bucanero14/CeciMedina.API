using CeciMedina.Core.Enum;

namespace CeciMedina.Core.Models
{
    public class Traslado : BaseEntity
    {
        public Sucursal SucursalSalida { get; set; }
        public Sucursal SucursalEntrada { get; set; }
        public TrasladoStatus Status { get; set; }
    }
}