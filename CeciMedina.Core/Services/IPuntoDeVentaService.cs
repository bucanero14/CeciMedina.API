using System.Threading.Tasks;
using CeciMedina.Core.Models;

namespace CeciMedina.Core.Services
{
    public interface IPuntoDeVentaService
    {
        Task GenerarVenta(Pedido pedido);
        Task GenerarDevolucion(int pedidoId);
        // TODO: Generar cotizaciones y encargos
    }
}