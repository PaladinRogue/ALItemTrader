using ALItemTrader.Domain;

namespace ALItemTrader.Persistence.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T player);
    }
}
