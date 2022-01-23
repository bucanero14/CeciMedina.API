using System;
using CeciMedina.Core.Enum;

namespace CeciMedina.Core.Models
{
    public class HistorialInventario : BaseEntity
    {
        public Sucursal Sucursal { get; set; }
        public Producto Producto { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public HistorialInventarioStatus Status { get; set; }
    }
}