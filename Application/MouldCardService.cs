using Moulding.Domain.MouldCards;

namespace Moulding.Application;

public class MouldCardService : IMouldCardService
{
    public async Task<IEnumerable<MouldCard>> GetAllMouldCardsAsync()
    {
        return new List<MouldCard>();
    }

    public async Task<IEnumerable<MouldCard>> GetMouldCardsAsync(
        MouldingMachineId mouldingMachineId
    )
    {
        return new List<MouldCard>();
    }
}
