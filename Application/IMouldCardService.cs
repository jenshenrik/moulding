using Moulding.Domain.MouldCards;

namespace Moulding.Application;

public interface IMouldCardService
{
    Task<IEnumerable<MouldCard>> GetAllMouldCardsAsync();
    Task<MouldCard?> GetMouldCardByIdAsync(Guid mouldCardId);
}
