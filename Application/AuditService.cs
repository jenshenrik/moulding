using Moulding.Domain.Alerts;
using Moulding.Domain.Audits;
using Moulding.Domain.MouldCards;
using Moulding.Infrastructure.MouldCardRepository;
using Moulding.Infrastructure.MouldingMachineClient;
using Moulding.Infrastructure.UnitOfWork;

namespace Moulding.Application;

public class AuditService : IAuditService
{
    private readonly IMouldCardRepository _mouldCardRepository;
    private readonly IMouldingMachineClient _mouldingMachineClient;
    private readonly IUnitOfWork _unitOfWork;

    public AuditService(
        IMouldCardRepository mouldCardRepository,
        IMouldingMachineClient mouldingMachineClient,
        IUnitOfWork unitOfWork
    )
    {
        _mouldCardRepository = mouldCardRepository;
        _mouldingMachineClient = mouldingMachineClient;
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyCollection<Alert>> RunProcessAudit(Guid mouldCardId)
    {
        MouldCard mouldCard = await GetMouldCard(mouldCardId);

        var audit = Audit.Create(mouldCard);

        var machineValues = await _mouldingMachineClient.ReadMachineValues(
            mouldCard.MouldingMachineId
        );

        audit.PerformProcessAudit(machineValues);

        await _unitOfWork.SaveChangesAsync();

        return audit.Alerts;
    }

    private async Task<MouldCard> GetMouldCard(Guid mouldCardId)
    {
        var mouldCard = await _mouldCardRepository.GetByIdAsync(MouldCardId.Create(mouldCardId));
        if (mouldCard == null)
        {
            throw new ArgumentException($"No mould card with id {mouldCardId} found.");
        }

        return mouldCard;
    }
}
