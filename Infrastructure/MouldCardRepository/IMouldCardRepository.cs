using Moulding.Domain.MouldCards;

namespace Moulding.Infrastructure.MouldCardRepository;

public interface IMouldCardRepository
{
    Task<IEnumerable<MouldCard>> GetAllAsync();
    Task<MouldCard?> GetByIdAsync(MouldCardId id);
}
