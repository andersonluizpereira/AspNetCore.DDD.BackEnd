using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Core.Commands;

namespace Integration.Domain.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        CommandResponse Commit();
    }
}
