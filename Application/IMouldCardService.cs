using Moulding.Domain.MouldCards;

namespace Moulding.Application;

/// <summary>
/// Business service for querying mould cards.
/// </summary>
public interface IMouldCardService
{
    Task<IEnumerable<MouldCard>> GetAllMouldCardsAsync();
    Task<MouldCard?> GetMouldCardByIdAsync(Guid mouldCardId);
}
