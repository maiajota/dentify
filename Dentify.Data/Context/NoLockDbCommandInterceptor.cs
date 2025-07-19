using System.Data.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Dentify.Data.Context;

public class NoLockDbCommandInterceptor : DbCommandInterceptor
{
    public override InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
    {
        ApplyReadUncommited(command);
        return result;
    }

    public override ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(DbCommand command, CommandEventData eventData,
        InterceptionResult<DbDataReader> result, CancellationToken cancellationToken = default)
    {
        ApplyReadUncommited(command);
        return new ValueTask<InterceptionResult<DbDataReader>>(result);
    }

    private static void ApplyReadUncommited(DbCommand command)
    {
        command.CommandText = $"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;{Environment.NewLine}{command.CommandText}";
    }
}
