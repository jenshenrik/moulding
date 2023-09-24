namespace Moulding.Infrastructure.UnitOfWork;

/// <summary>
/// Abstraction around a context for purposes of persistance.
/// </summary>
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
