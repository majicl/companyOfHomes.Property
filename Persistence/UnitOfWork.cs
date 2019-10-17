using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.SeedWork;

namespace Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(
            DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await this._dataContext.SaveChangesAsync(cancellationToken);
        }
    }
}
