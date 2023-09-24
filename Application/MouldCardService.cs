using Moulding.Domain.MouldCards;
using Moulding.Infrastructure.MouldCardRepository;

namespace Moulding.Application;

public class MouldCardService : IMouldCardService
{
    private readonly IMouldCardRepository _mouldCardRepository;

    public MouldCardService(IMouldCardRepository mouldCardRepository)
    {
        _mouldCardRepository = mouldCardRepository;
    }

    public async Task<IEnumerable<MouldCard>> GetAllMouldCardsAsync()
    {
        return await _mouldCardRepository.GetAllAsync();
    }

    public async Task<MouldCard?> GetMouldCardByIdAsync(Guid mouldCardId)
    {
        var id = MouldCardId.Create(mouldCardId);
        return await _mouldCardRepository.GetByIdAsync(id);
    }
}
