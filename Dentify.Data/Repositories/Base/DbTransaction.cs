using Dentify.Core.Interfaces.Repositories.Base;
using Dentify.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace Dentify.Data.Repositories.Base;

public class DbTransaction(IDbContextTransaction dbContextTransaction, ApplicationDbContext dbContext) : IDbTransaction
{
    private readonly IDbContextTransaction _dbContextTransaction = dbContextTransaction;
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task CommitAsync(CancellationToken cancellationToken = default)
    {
        await _dbContextTransaction.CommitAsync(cancellationToken);
        _dbContext.ChangeTracker.Clear();
    }

    public void Commit()
    {
        _dbContextTransaction.Commit();
        _dbContext.ChangeTracker.Clear();
    }

    public async Task RollbackAsync(CancellationToken cancellationToken = default)
    {
        await _dbContextTransaction.RollbackAsync(cancellationToken);
        _dbContext.ChangeTracker.Clear();
    }

    public void Rollback()
    {
        _dbContextTransaction.Rollback();
        _dbContext.ChangeTracker.Clear();
    }
}
