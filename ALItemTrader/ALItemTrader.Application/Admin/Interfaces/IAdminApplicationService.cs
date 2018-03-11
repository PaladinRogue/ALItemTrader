
using System;
using System.Collections.Generic;
using ALItemTrader.Application.Admin.Models;

namespace ALItemTrader.Application.Admin.Interfaces
{
    public interface IAdminApplicationService
    {
        IList<AdminAdto> GetAdmins();
        AdminAdto GetAdminById(Guid id);
    }
}
