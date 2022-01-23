using System;
using System.Collections.Generic;

namespace CeciMedina.Core.Models
{
    public class Pedido : BaseEntity
    {
        public Sucursal Sucursal { get; set; }
        public FormaPago FormaPago { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public int TotalProductos { get; set; }
        public DateTime Fecha { get; set; }

        public virtual List<DetallePedido> Detalles { get; set; }
        public virtual int SucursalId { get; set; }
        public virtual int FormaPagoId { get; set; }
    }
}