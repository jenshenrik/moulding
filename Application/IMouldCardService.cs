using Moulding.Domain;

namespace Moulding.Application;

public interface IMouldCardService
{
    Task<IEnumerable<MouldCard>> GetAllMouldCardsAsync();
    Task<IEnumerable<MouldCard>> GetMouldCardsAsync(MouldingMachineId mouldingMachineId);
}
