using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Core.Commands;
using Integration.Domain.Entities.Interfaces;
using Integration.Infra.Data.Contexts;

namespace Integration.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            this._context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = this._context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}