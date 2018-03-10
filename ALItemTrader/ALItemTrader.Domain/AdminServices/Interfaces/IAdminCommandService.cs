using ALItemTrader.Domain.AdminServices.Models;
using ALItemTrader.Domain.Interfaces;

namespace ALItemTrader.Domain.AdminServices.Interfaces
{
    public interface IAdminCommandService : ICommandService<AdminDdto>
    {
    }
}
