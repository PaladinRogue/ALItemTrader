using System;
using System.Collections.Generic;

namespace ALItemTrader.Domain.Interfaces
{
    public interface IQueryService<T>
    {
        IList<T> GetAll();
        T Get(Guid id);
    }
}
