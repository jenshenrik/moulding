namespace Moulding.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await Task.FromResult(1);
    }
}
