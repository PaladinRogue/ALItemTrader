
namespace ALItemTrader.Domain.Interfaces
{
    public interface ICommandService<in T>
    {
        bool Create(T entity);
    }
}
