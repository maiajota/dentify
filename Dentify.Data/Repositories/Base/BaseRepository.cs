using Dentify.Core.Interfaces.Repositories.Base;
using Dentify.Data.Context;

namespace Dentify.Data.Repositories.Base;

public abstract class BaseRepository(ApplicationDbContext dbContext) : IBaseRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<IDbTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
    {
        var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);
        return new DbTransaction(transaction, _dbContext);
    }

    public IDbTransaction BeginTransaction()
    {
        var transaction = _dbContext.Database.BeginTransaction();
        return new DbTransaction(transaction, _dbContext);
    }
}
