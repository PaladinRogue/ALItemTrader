using System;

namespace ALItemTrader.Domain.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(Guid id);
        void Add(T obj);
        void Update(T obj);
        void Delete(Guid id);
    }
}
