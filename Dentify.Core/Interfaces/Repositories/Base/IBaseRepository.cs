using System.Data;

namespace Dentify.Core.Interfaces.Repositories.Base;

public interface IBaseRepository
{
    Task<IDbTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    IDbTransaction BeginTransaction();
}
