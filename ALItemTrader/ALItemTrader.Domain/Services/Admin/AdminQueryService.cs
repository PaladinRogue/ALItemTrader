using System;
using ALItemTrader.Domain.Interfaces;

namespace ALItemTrader.Domain.Services.Admin
{
    public class AdminQueryService : IQueryService<Domain.Admin>
    {
        public Domain.Admin Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
