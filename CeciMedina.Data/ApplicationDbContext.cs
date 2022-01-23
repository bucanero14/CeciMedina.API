using System;
using System.Linq;
using CeciMedina.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using AspNetCoreHero.EntityFrameworkCore.AuditTrail.Contexts;

namespace CeciMedina.Data
{
    public class ApplicationDbContext : AuditableIdentityContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetallePedido> DetallesPedido { get; set; }
        public DbSet<FormaPago> FormasPago { get; set; }
        public DbSet<HistorialInventario> HistorialInventario { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Traslado> Traslados { get; set; }
        public DbSet<TrasladoInventario> TrasladoInventarios { get; set; }
    }
}