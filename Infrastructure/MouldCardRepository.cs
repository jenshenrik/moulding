using Moulding.Domain;
using Moulding.Domain.MouldCards;

namespace Moulding.Infrastructure;

public class MouldCardRepository : IMouldCardRepository
{
    private List<MouldCard> _mouldCards;

    public MouldCardRepository()
    {
        _mouldCards = new List<MouldCard>
        {
            MouldCard.Create(
                MouldingMachineId.Create(),
                12,
                5,
                190f,
                PressureValue.Create(45, "Bar"),
                PressureValue.Create(55, "Bar")
            ),
            MouldCard.Create(
                MouldingMachineId.Create(),
                15,
                7,
                210f,
                PressureValue.Create(65, "PSI"),
                PressureValue.Create(76, "Bar")
            )
        };
    }

    public async Task<IEnumerable<MouldCard>> GetAllAsync()
    {
        return await Task.FromResult(_mouldCards);
    }

    public async Task<MouldCard?> GetByIdAsync(MouldCardId id)
    {
        return await Task.FromResult(_mouldCards.FirstOrDefault(mc => mc.Id == id));
    }
}
