using System;

namespace ALItemTrader.Domain.Interfaces
{
    internal interface IQueryService<out T>
    {
        T Get(Guid id);
    }
}
