using ALItemTrader.Domain.AdminServices.Models;
using ALItemTrader.Domain.Interfaces;

namespace ALItemTrader.Domain.AdminServices.Interfaces
{
    public interface IAdminQueryService : IQueryService<AdminProjection>
    {
    }
}
