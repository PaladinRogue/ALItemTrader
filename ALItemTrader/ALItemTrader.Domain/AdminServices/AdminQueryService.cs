using System;
using ALItemTrader.Domain.AdminServices.Projections;
using ALItemTrader.Domain.Interfaces;

namespace ALItemTrader.Domain.AdminServices
{
    public class AdminQueryService : IQueryService<AdminProjection>
    {
        public AdminProjection Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
