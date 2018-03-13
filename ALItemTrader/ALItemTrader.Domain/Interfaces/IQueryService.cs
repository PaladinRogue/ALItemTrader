using System;
using System.Collections.Generic;

namespace ALItemTrader.Domain.Interfaces
{
    public interface IQueryService<T>
    {
        T Get(Guid id);
        IList<T> GetAll();
    }
}
