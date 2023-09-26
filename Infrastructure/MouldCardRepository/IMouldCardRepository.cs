using Moulding.Domain.MouldCards;

namespace Moulding.Infrastructure.MouldCardRepository;

/// <summary>
/// Query mould cards from persistance layer.
/// </summary>
public interface IMouldCardRepository
{
    Task<IEnumerable<MouldCard>> GetAllAsync();
    Task<MouldCard?> GetByIdAsync(MouldCardId id);
}
