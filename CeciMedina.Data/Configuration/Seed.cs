using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CeciMedina.Core.Models;
using CeciMedina.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace CeciMedina.Data.Configuration
{
    public class Seed
    {
        public static async Task SeedData(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.Roles.Any())
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };

                await roleManager.CreateAsync(role);
            }
            
            if (!userManager.Users.Any())
            {
                var user = new ApplicationUser
                {
                    UserName = "admin",
                    Nombre = "Raúl",
                    ApellidoPaterno = "Magaña",
                    ApellidoMaterno = "Gonzalez",
                    FechaDeNacimiento = new DateTime(1989, 12, 6)
                };

                await userManager.CreateAsync(user, "Password123!");
                await userManager.AddToRoleAsync(user, "Admin");
            }

            if (!context.FormasPago.Any())
            {
                var formasDePago = new List<FormaPago>
                {
                    new()
                    {
                        Nombre = "Efectivo",
                        UsaCaja = true
                    },
                    new()
                    {
                        Nombre = "Tarjeta",
                        UsaCaja = false
                    },
                    new()
                    {
                        Nombre = "Rappi",
                        UsaCaja = false
                    }
                };
                await context.FormasPago.AddRangeAsync(formasDePago);
                await context.SaveChangesAsync();
            }

            if (!context.Categorias.Any())
            {
                var categorias = new List<Categoria>
                {
                    new Categoria()
                    {
                        Nombre = "Pasteles 15 pers."
                    },
                    new Categoria()
                    {
                        Nombre = "Pasteles 20 pers."
                    },
                    new Categoria()
                    {
                        Nombre = "Pasteles 30 pers."
                    },
                    new Categoria()
                    {
                        Nombre = "Postres personales"
                    }
                };

                await context.Categorias.AddRangeAsync(categorias);
                await context.SaveChangesAsync();
            }

            if (!context.Productos.Any())
            {
                var productos = new List<Producto>
                {
                    new()
                    {
                        Categoria = context.Categorias.Find(1),
                        Nombre = "Pastel de Tres Leches 15 personas",
                        PrecioBase = Math.Round(180m / 1.16m, 2),
                        Iva = Math.Round(180m - (180m / 1.16m), 2),
                        Descuento = 0m,
                        PrecioFinal = 180m
                    },
                    new()
                    {
                        Categoria = context.Categorias.Find(2),
                        Nombre = "Pastel de Tres Leches 20 personas",
                        PrecioBase = Math.Round(250m / 1.16m, 2),
                        Iva = Math.Round(250m - (250m / 1.16m), 2),
                        Descuento = 0m,
                        PrecioFinal = 250m
                    },
                    new()
                    {
                        Categoria = context.Categorias.Find(3),
                        Nombre = "Pastel de Tres Leches 30 personas",
                        PrecioBase = Math.Round(300m / 1.16m, 2),
                        Iva = Math.Round(300m - (300m / 1.16m), 2),
                        Descuento = 0m,
                        PrecioFinal = 300m
                    },
                    new()
                    {
                        Categoria = context.Categorias.Find(4),
                        Nombre = "Copa Tiramisú",
                        PrecioBase = Math.Round(70m / 1.16m, 2),
                        Iva = Math.Round(70m - (70m / 1.16m), 2),
                        Descuento = 0m,
                        PrecioFinal = 70m
                    }
                };

                await context.Productos.AddRangeAsync(productos);
                await context.SaveChangesAsync();
            }

            if (!context.Sucursales.Any())
            {
                var sucursales = new List<Sucursal>()
                {
                    new()
                    {
                        Nombre = "Matriz",
                        Telefono = "1234567890",
                        TienePv = true
                    },
                    new()
                    {
                        Nombre = "Cocina",
                        Telefono = "1234567890",
                        TienePv = false
                    },
                    new()
                    {
                        Nombre = "Progreso",
                        Telefono = "1234567890",
                        TienePv = true
                    },
                    new()
                    {
                        Nombre = "Pocito",
                        Telefono = "1234567890",
                        TienePv = true
                    }
                };

                await context.Sucursales.AddRangeAsync(sucursales);
                await context.SaveChangesAsync();
            }

            if (!context.Inventarios.Any())
            {
                var inventarios = new List<Inventario>()
                {
                    new()
                    {
                        Producto = context.Productos.Find(1),
                        Sucursal = context.Sucursales.Find(1),
                        PrecioBase = Math.Round(150m / 1.16m, 2),
                        Iva = Math.Round(150m - (150m / 1.16m), 2),
                        Descuento = 0m,
                        PrecioFinal = 150m,
                        Existencia = 10,
                        ExistenciaMinima = 0,
                        ExistenciaMaxima = 10
                    },
                    new()
                    {
                        Producto = context.Productos.Find(2),
                        Sucursal = context.Sucursales.Find(1),
                        PrecioBase = Math.Round(200m / 1.16m, 2),
                        Iva = Math.Round(200m - (200m / 1.16m), 2),
                        Descuento = 0m,
                        PrecioFinal = 200m,
                        Existencia = 10,
                        ExistenciaMinima = 0,
                        ExistenciaMaxima = 10
                    },
                    new()
                    {
                        Producto = context.Productos.Find(3),
                        Sucursal = context.Sucursales.Find(1),
                        PrecioBase = Math.Round(250m / 1.16m, 2),
                        Iva = Math.Round(250m - (250m / 1.16m), 2),
                        Descuento = 0m,
                        PrecioFinal = 250m,
                        Existencia = 10,
                        ExistenciaMinima = 0,
                        ExistenciaMaxima = 10
                    },
                    new()
                    {
                        Producto = context.Productos.Find(4),
                        Sucursal = context.Sucursales.Find(1),
                        PrecioBase = Math.Round(50m / 1.16m, 2),
                        Iva = Math.Round(50m - (50m / 1.16m), 2),
                        Descuento = 0m,
                        PrecioFinal = 50m,
                        Existencia = 10,
                        ExistenciaMinima = 0,
                        ExistenciaMaxima = 10
                    }
                };

                await context.Inventarios.AddRangeAsync(inventarios);
                await context.SaveChangesAsync();
            }
        }
    }
}