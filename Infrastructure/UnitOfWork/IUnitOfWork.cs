namespace Moulding.Infrastructure.UnitOfWork;

/// <summary>
/// Abstraction around a context for purposes of persistance.
/// Mocked since we're just persisting to memory.
/// </summary>
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
