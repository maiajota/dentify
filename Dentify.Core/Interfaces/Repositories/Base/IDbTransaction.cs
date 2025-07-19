namespace Dentify.Core.Interfaces.Repositories.Base;

public interface IDbTransaction
{
    Task CommitAsync(CancellationToken cancellationToken = default);
    void Commit();

    Task RollbackAsync(CancellationToken cancellationToken = default);
    void Rollback();
}
