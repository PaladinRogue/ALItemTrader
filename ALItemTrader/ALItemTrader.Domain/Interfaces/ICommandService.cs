
namespace ALItemTrader.Domain.Interfaces
{
    internal interface ICommandService<in T>
    {
        bool Create(T entity);
    }
}
