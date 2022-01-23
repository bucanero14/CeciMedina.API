using System;
using System.Threading.Tasks;
using CeciMedina.Core.Data;
using CeciMedina.Core.Enum;
using CeciMedina.Core.Models;
using CeciMedina.Core.Services;
using CeciMedina.Data;

namespace CeciMedina.Services
{
    public class PuntoDeVentaService : IPuntoDeVentaService
    {
        private bool _disposed;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<HistorialInventario> _historialInventarioRepo;
        private readonly IRepository<Inventario> _inventarioRepo;
        private readonly IRepository<Pedido> _pedidoRepo;

        public PuntoDeVentaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _historialInventarioRepo = _unitOfWork.Repository<HistorialInventario>();
            _inventarioRepo = _unitOfWork.Repository<Inventario>();
            _pedidoRepo = _unitOfWork.Repository<Pedido>();
        }
        
        public async Task GenerarVenta(Pedido pedido)
        {
            using (var txn = _unitOfWork.BeginTransaction())
            {
                _pedidoRepo.Insert(pedido);
                foreach (var detalle in pedido.Detalles)
                {
                    _historialInventarioRepo.Insert(new()
                    {
                        Sucursal = pedido.Sucursal,
                        Fecha = DateTime.Now,
                        Producto = detalle.Producto,
                        Cantidad = detalle.Cantidad,
                        Status = HistorialInventarioStatus.Venta
                    });

                    var inventario = await _inventarioRepo.GetSingleAsync(detalle.Producto.Id);

                    inventario.Existencia -= detalle.Cantidad;

                    _inventarioRepo.Update(inventario);
                }

                await _unitOfWork.SaveChangesAsync();
                await txn.CommitAsync();
            }
        }

        public Task GenerarDevolucion(int pedidoId)
        {
            throw new System.NotImplementedException();
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _unitOfWork.Dispose();
            }
            _disposed = true;
        }
    }
}