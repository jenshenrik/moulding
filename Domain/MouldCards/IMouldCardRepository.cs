namespace Moulding.Domain.MouldCards;

public interface IMouldCardRepository
{
    Task<IEnumerable<MouldCard>> GetAllAsync();
    Task<MouldCard?> GetByIdAsync(MouldCardId id);
}
