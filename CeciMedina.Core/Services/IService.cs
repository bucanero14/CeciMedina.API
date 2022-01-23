using CeciMedina.Core.Data;
using System;

namespace CeciMedina.Core.Services
{
    public interface IService : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
