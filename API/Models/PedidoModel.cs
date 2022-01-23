using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CeciMedina.Core.Models;

namespace CeciMedina.API.Models
{
    public class PedidoModel
    {
        [Required]
        public int Sucursal { get; set; }
        
        [Required]
        public string FormaPago { get; set; }
        
        [Required]
        public decimal Subtotal { get; set; }
        
        [Required]
        public decimal Descuento { get; set; }
        
        [Required]
        public decimal Iva { get; set; }
        
        [Required]
        public decimal Total { get; set; }
        
        [Required]
        public int TotalProductos { get; set; }
        
        [Required]
        public DateTime Fecha { get; set; }
        
        [Required]
        public List<DetallePedido> Detalles { get; set; }
    }
}